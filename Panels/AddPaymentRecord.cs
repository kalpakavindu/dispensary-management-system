using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dispensary_management_system.Panels
{
    public partial class AddPaymentRecord : Form
    {
        private Database connection;
        private int cashier_id;
        private DataTable quotaTable;
        private int price_sub_total;

        public AddPaymentRecord(int id)
        {
            InitializeComponent();
            connection = new Database();
            cashier_id = id;
            price_sub_total = 0;
            loadCombos();

            quotaTable = new DataTable();
            quotaTable.Columns.Add("Product Name", typeof(string));
            quotaTable.Columns.Add("Qty", typeof(int));
            quota.DataSource = quotaTable;
        }

        private void loadCombos()
        {
            try
            {
                string query = "SELECT name FROM ProductTable";
                DataTable productNames = connection.GetData(query);
                foreach (DataRow row in productNames.Rows)
                {
                    product_in.Items.Add((string)row["name"]);
                }
            }
            catch(Exception ex)
            {
                if (MessageBox.Show(ex.Message, "Unexpected Error", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

        private void add_product_btn_Click(object sender, EventArgs e)
        {
            if(product_in.Text != "" && qty_in.Text != "" || qty_in.Text != "0")
            {
                quotaTable.Rows.Add(product_in.Text, Convert.ToInt32(qty_in.Text));

                string query = $"SELECT * FROM ProductTable WHERE name='{product_in.Text}'";
                DataTable productData = connection.GetData(query);
                price_sub_total += (int)productData.Rows[0]["price"] * Convert.ToInt32(qty_in.Text);
                sub_total.Text = price_sub_total.ToString();
                
                product_in.Text = "";
                qty_in.Text = "";
                quota.DataSource = quotaTable;
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if(payment_method.Text == "" || sub_total.Text == "")
            {
                MessageBox.Show("No Quota found", "Error", MessageBoxButtons.OK);
            }
            else
            {
                string today = DateTime.Now.ToString("dd/MM/yyyy");
                string invoice_id = DateTime.Now.ToString("ddMMyyyy");
                int dc = discount.Text == "" ? 0 : Convert.ToInt32(discount.Text);
                string query = $"INSERT INTO PaymentTable VALUES ({dc},'{payment_method.Text}',{cashier_id},'{today}',{price_sub_total},'{invoice_id}')";
                connection.SetData(query);

                query = $"SELECT id FROM PaymentTable WHERE invoice_id={invoice_id}";
                DataTable paymentIds = connection.GetData(query);
                int last_payment_id = (int)paymentIds.Rows[0]["id"];

                foreach(DataRow row in quotaTable.Rows)
                {
                    string productName = (string)row["Product Name"];
                    query = $"SELECT id FROM ProductTable WHERE name='{productName}'";
                    DataTable productIds = connection.GetData(query);
                    int productId = (int)productIds.Rows[0]["id"];
                    int qty = (int)row["Qty"];

                    query = $"INSERT INTO QuotaTable VALUES ({last_payment_id},{productId},{qty})";
                    connection.SetData(query);
                }

                clearEntries();
            }
        }

        private void clearEntries()
        {
            payment_method.Text = "";
            discount.Text = "";
            price_sub_total = 0;
            sub_total.Text = "";
            quotaTable.Rows.Clear();
            quota.DataSource = quotaTable;
        }
    }
}
