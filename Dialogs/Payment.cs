using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dispensary_management_system.Dialogs
{
    public partial class Payment : Form
    {
        private Database connection;
        private int payment_id;
        private DataTable paymentData;

        public Payment(int id, bool showDel = true)
        {
            InitializeComponent();
            connection = new Database();
            payment_id = id;
            del_btn.Visible = showDel;
            try
            {
                string query = $"SELECT * FROM PaymentTable WHERE id={payment_id}";
                paymentData = connection.GetData(query);
            }catch(Exception ex)
            {
                if (MessageBox.Show(ex.Message, "Unexpected error", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            loadData();
        }

        private void loadData()
        {
            try
            { 
                string query = $"SELECT * FROM QuotaTable WHERE payment_id={payment_id}";
                DataTable quotaData = connection.GetData(query);
                quotaData.Columns.Remove("payment_id");

                quota.DataSource = quotaData;

                payment_date.Text = (string)paymentData.Rows[0]["payment_date"];
                sub_total.Text = ((int)paymentData.Rows[0]["total_price"]).ToString();
                discount.Text = ((int)paymentData.Rows[0]["discount"]).ToString();
                net_total.Text = ((int)paymentData.Rows[0]["total_price"] - (int)paymentData.Rows[0]["discount"]).ToString();
                payment_method.Text = (string)paymentData.Rows[0]["payment_method"];

                int cashier_id = (int)paymentData.Rows[0]["cashier"];
                query = $"SELECT * FROM StaffTable WHERE id={cashier_id}";
                DataTable cashierData = connection.GetData(query);

                string fname = (string)cashierData.Rows[0]["first_name"];
                string lname = (string)cashierData.Rows[0]["last_name"];

                cashier.Text = $"{fname} {lname}";
            }
            catch(Exception ex)
            {
                if (MessageBox.Show(ex.Message, "Unexpected error", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

        private void quota_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Product productDetails = new Product(Convert.ToInt32(quota.Rows[e.RowIndex].Cells[1].Value),false);
            productDetails.ShowDialog();
        }

        private void cashier_btn_Click(object sender, EventArgs e)
        {
            StaffMember cashierDetails = new StaffMember((int)paymentData.Rows[0]["cashier"], false, false);
            cashierDetails.ShowDialog();
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"DELETE FROM QuotaTable WHERE payment_id={payment_id}";
                connection.SetData(query);

                query = $"DELETE FROM PaymentTable WHERE id={payment_id}";
                connection.SetData(query);
            }catch(Exception ex)
            {
                if (MessageBox.Show(ex.Message, "Unexpected error", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }

            this.Close();
        }
    }
}
