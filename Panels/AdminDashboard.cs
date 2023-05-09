using dispensary_management_system.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dispensary_management_system.Panels
{
    public partial class AdminDashboard : Form
    {
        private Database connection;
        private int editKey;

        public AdminDashboard()
        {
            InitializeComponent();
            connection = new Database();
            editKey = 0;
            transaction_filters.SelectedItem = "All The Time";
            loadData();
            stock_filters.SelectedItem = "All";
        }

        private void loadData()
        {
            // set product filters
            string query = "SELECT * FROM CategoryTable";
            DataTable categoryData = connection.GetData(query);
            category_list.DataSource = categoryData;
            stock_filters.Items.Clear();
            stock_filters.Items.Add("All");
            foreach (DataRow cr in categoryData.Rows)
            {
                stock_filters.Items.Add((string)cr["name"]);
            }

            // set transaction_label text
            transactions_label.Text = getTransactionCount("").ToString();
            
            // set stock_label text
            stock_label.Text = getStockCount("").ToString();

            // set staff_label text
            query = "SELECT * FROM StaffTable";
            staff_label.Text = connection.GetData(query).Rows.Count.ToString();

            // set summery
            string today = DateTime.Now.ToString("dd/MM/yyyy");
            query = $"SELECT * FROM PaymentTable WHERE payment_date='{today}'";
            DataTable paymentDetails = connection.GetData(query);
            int earnings_tot = 0;
            int products_tot = 0;
            foreach(DataRow pr in paymentDetails.Rows)
            {
                earnings_tot += (int)pr["total_price"] - (int)pr["discount"];
                query = $"SELECT id FROM QuotaTable WHERE payment_id={(int)pr["id"]}";
                DataTable quotaDetails = connection.GetData(query);
                products_tot += quotaDetails.Rows.Count;
            }
            total_earnings.Text = earnings_tot.ToString();
            products_sold.Text = products_tot.ToString();
        }

        private int getTransactionCount(string range)
        {
            string query;
            if (range == "Today" || range == "Yesterday")
            {
                switch (range)
                {
                    case "Today":
                        string today = DateTime.Now.ToString("dd/MM/yyyy");
                        query = $"SELECT * FROM PaymentTable WHERE payment_date='{today}'";
                        break;
                    default:
                        string yesterday = DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy");
                        query = $"SELECT * FROM PaymentTable WHERE payment_date='{yesterday}'";
                        break;
                }
                DataTable paymentDetails = connection.GetData(query);
                return paymentDetails.Rows.Count;
            }
            else
            {
                query = "SELECT * FROM PaymentTable";
                DataTable mainPaymentDetails = connection.GetData(query);
                DataTable paymentDetails = mainPaymentDetails.Copy();

                if(range == "This Week")
                {
                    for (int i = 0; i < 7; i++)
                    {
                        string date = DateTime.Now.AddDays(i * -1).ToString("dd/MM/yyyy");
                        foreach(DataRow row in mainPaymentDetails.Rows)
                        {
                            if ((string)row["payment_date"] == date)
                            {
                                DataRow tr = paymentDetails.Rows[mainPaymentDetails.Rows.IndexOf(row)];
                                paymentDetails.Rows.Remove(tr);
                            }
                        }
                    }
                    return paymentDetails.Rows.Count;
                }else if(range == "This Month")
                {
                    for (int i = 0; i < 30; i++)
                    {
                        string date = DateTime.Now.AddDays(i * -1).ToString("dd/MM/yyyy");
                        foreach (DataRow row in mainPaymentDetails.Rows)
                        {
                            if ((string)row["payment_date"] == date)
                            {
                                DataRow tr = paymentDetails.Rows[mainPaymentDetails.Rows.IndexOf(row)];
                                paymentDetails.Rows.Remove(tr);
                            }
                        }
                    }
                    return paymentDetails.Rows.Count;
                }else if(range == "This Year")
                {
                    for (int i = 0; i < 365; i++)
                    {
                        string date = DateTime.Now.AddDays(i * -1).ToString("dd/MM/yyyy");
                        foreach (DataRow row in mainPaymentDetails.Rows)
                        {
                            if ((string)row["payment_date"] == date)
                            {
                                DataRow tr = paymentDetails.Rows[mainPaymentDetails.Rows.IndexOf(row)];
                                paymentDetails.Rows.Remove(tr);
                            }
                        }
                    }
                    return paymentDetails.Rows.Count;
                }
                else
                {
                    return paymentDetails.Rows.Count;
                }
            }
        }

        private int getStockCount(string category_name)
        {
            if (category_name == "")
            {
                string query = "SELECT * FROM ProductTable";
                return connection.GetData(query).Rows.Count;
            }
            else
            {
                string query = $"SELECT id FROM CategoryTable WHERE name='{category_name}'";
                DataTable categoryDetails = connection.GetData(query);
                if (categoryDetails.Rows.Count == 0)
                {
                    MessageBox.Show($"Category {category_name} not found in the database.", "Not Found", MessageBoxButtons.OK);
                    return 0;
                }
                else
                {
                    query = $"SELECT * FROM ProductTable WHERE category={(int)categoryDetails.Rows[0]["id"]}";
                    DataTable productDetails = connection.GetData(query);
                    return productDetails.Rows.Count;
                }
            }
        }

        private void transaction_filter_btn_Click(object sender, EventArgs e)
        {
            if (transaction_filters.Text == "")
            {
                MessageBox.Show("Select a filter first.", "Error", MessageBoxButtons.OK);
            }
            else 
            {
                transactions_label.Text = getTransactionCount(transaction_filters.Text).ToString();
            }
        }

        private void stock_filter_btn_Click(object sender, EventArgs e)
        {
            if(stock_filters.Text == "")
            {
                MessageBox.Show("Select a filter first.", "Error", MessageBoxButtons.OK);
            }
            else if(stock_filters.Text == "All")
            {
                stock_label.Text = getStockCount("").ToString();
            }
            else
            {
                stock_label.Text = getStockCount(stock_filters.Text).ToString();
            }
        }

        private void add_cato_btn_Click(object sender, EventArgs e)
        {
            if(category_name_in.Text == "")
            {
                MessageBox.Show("Please give me a name to add as a category.", "Error", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    string query = $"INSERT INTO CategoryTable VALUES('{category_name_in.Text}')";
                    connection.SetData(query);
                    category_name_in.Text = "";
                    loadData();
                }
                catch(Exception ex)
                {
                    if(MessageBox.Show(ex.Message,"Unexpected Error",MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }
            }
        }

        private void category_list_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editKey = Convert.ToInt32(category_list.Rows[e.RowIndex].Cells[0].Value);
            category_name_in.Text = category_list.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void upd_cato_btn_Click(object sender, EventArgs e)
        {
            if (editKey == 0) {
                MessageBox.Show("Select a category to edit first.", "Error", MessageBoxButtons.OK);
            }
            else if (category_name_in.Text == "")
            {
                MessageBox.Show("Please give me a name to add as a category.", "Error", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    string query = $"UPDATE CategoryTable SET name='{category_name_in.Text}' WHERE id={editKey}";
                    connection.SetData(query);
                    category_name_in.Text = "";
                    loadData();
                }
                catch (Exception ex)
                {
                    if (MessageBox.Show(ex.Message, "Unexpected Error", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }
            }
        }

        private void del_cato_btn_Click(object sender, EventArgs e)
        {
            if (editKey == 0)
            {
                MessageBox.Show("Select a category to delete first.", "Error", MessageBoxButtons.OK);
            }
            else
            {
                CategoryDelete categoryDelete = new CategoryDelete(editKey);
                categoryDelete.FormClosed += categoryDelete_FormClosed;
                categoryDelete.ShowDialog();
            }
        }

        private void categoryDelete_FormClosed(object sender, FormClosedEventArgs e)
        {
            loadData();
        }
    }
}
