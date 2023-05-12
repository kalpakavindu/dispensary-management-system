using dispensary_management_system.Dialogs;
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
    public partial class AdminPayments : Form
    {
        Database connection;
        public AdminPayments()
        {
            InitializeComponent();
            connection = new Database();
            loadCombos();
            time_range.SelectedItem = "All the Time";

            DataTable paymentDataSource = filterPaymentData("","");
            payments_list.DataSource = paymentDataSource;
        }

        private void loadCombos()
        {
            string query = $"SELECT first_name FROM StaffTable";
            DataTable staffData = connection.GetData(query);

            foreach (DataRow dr in staffData.Rows) {
                cashier.Items.Add((string)dr["first_name"]);
            }
        }

        private DataTable filterPaymentData(string filterCashierName, string filterTimeRange)
        {
            string query;

            if (filterCashierName == "")
            {
                if (filterTimeRange == "Today" || filterTimeRange == "Yesterday")
                {
                    switch (filterTimeRange)
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
                    return paymentDetails;
                }
                else
                {
                    query = "SELECT * FROM PaymentTable";
                    DataTable mainPaymentDetails = connection.GetData(query);
                    DataTable paymentDetails = mainPaymentDetails.Copy();

                    if (filterTimeRange == "This Week")
                    {
                        paymentDetails.Rows.Clear();
                        for (int i = 0; i < 7; i++)
                        {
                            string date = DateTime.Now.AddDays(i * -1).ToString("dd/MM/yyyy");
                            foreach (DataRow row in mainPaymentDetails.Rows)
                            {
                                if ((string)row["payment_date"] == date)
                                {
                                    paymentDetails.ImportRow(row);
                                }
                            }
                        }
                        return paymentDetails;
                    }
                    else if (filterTimeRange == "This Month")
                    {
                        paymentDetails.Rows.Clear();
                        for (int i = 0; i < 30; i++)
                        {
                            string date = DateTime.Now.AddDays(i * -1).ToString("dd/MM/yyyy");
                            foreach (DataRow row in mainPaymentDetails.Rows)
                            {
                                if ((string)row["payment_date"] == date)
                                {
                                    paymentDetails.ImportRow(row);
                                }
                            }
                        }
                        return paymentDetails;
                    }
                    else
                    {
                        return paymentDetails;
                    }
                }
            }
            else
            {
                query = $"SELECT id FROM StaffTable WHERE first_name='{filterCashierName}'";
                DataTable cashierData = connection.GetData(query);
                int cashierId = (int)cashierData.Rows[0]["id"];

                query = $"SELECT * FROM PaymentTable WHERE cashier={cashierId}";
                DataTable mainPaymentCashierFDetails = connection.GetData(query);
                DataTable paymentCashierFDetails = mainPaymentCashierFDetails.Clone();

                if(filterTimeRange == "Today" || filterTimeRange == "Yesterday")
                {
                    switch (filterTimeRange)
                    {
                        case "Today":
                            string today = DateTime.Now.ToString("dd/MM/yyyy");
                            foreach(DataRow r in mainPaymentCashierFDetails.Rows)
                            {
                                if ((string)r["payment_date"] != today)
                                {
                                    DataRow rowToRemove = paymentCashierFDetails.Rows[mainPaymentCashierFDetails.Rows.IndexOf(r)];
                                    paymentCashierFDetails.Rows.Remove(rowToRemove);
                                }
                            }
                            break;
                        default:
                            string yesterday = DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy");
                            foreach (DataRow r in mainPaymentCashierFDetails.Rows)
                            {
                                if ((string)r["payment_date"] != yesterday)
                                {
                                    DataRow rowToRemove = paymentCashierFDetails.Rows[mainPaymentCashierFDetails.Rows.IndexOf(r)];
                                    paymentCashierFDetails.Rows.Remove(rowToRemove);
                                }
                            }
                            break;
                    }

                    return paymentCashierFDetails;
                }
                else
                {
                    if(filterTimeRange == "This Week")
                    {
                        paymentCashierFDetails.Rows.Clear();
                        for (int i = 0; i < 7; i++)
                        { 
                            string date = DateTime.Now.AddDays(-i).ToString("dd/MM/yyyy");
                            foreach(DataRow row in mainPaymentCashierFDetails.Rows)
                            {
                                if ((string)row["payment_date"] == date)
                                {
                                    paymentCashierFDetails.ImportRow(row);
                                }
                            }
                        }
                        return paymentCashierFDetails;
                    }
                    else if(filterTimeRange == "This Month")
                    {
                        paymentCashierFDetails.Rows.Clear();
                        for (int i = 0; i < 30; i++)
                        {
                            string date = DateTime.Now.AddDays(-i).ToString("dd/MM/yyyy");
                            foreach (DataRow row in mainPaymentCashierFDetails.Rows)
                            {
                                if ((string)row["payment_date"] == date)
                                {
                                    paymentCashierFDetails.ImportRow(row);
                                }
                            }
                        }
                        return paymentCashierFDetails;
                    }
                    else { return paymentCashierFDetails; }
                }
            }
        }

        private void filter_btn_Click(object sender, EventArgs e)
        {
            DataTable filteredPaymentData = filterPaymentData(cashier.Text, time_range.Text);
            payments_list.DataSource = filteredPaymentData;
        }

        private void payments_list_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Payment paymentDetails = new Payment(Convert.ToInt32(payments_list.Rows[e.RowIndex].Cells[0].Value));
            paymentDetails.FormClosed += paymentDetails_FormClosed;
            paymentDetails.ShowDialog();
        }

        private void paymentDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            cashier.Text = "";
            time_range.SelectedItem = "All the Time";
            DataTable paymentDataSource = filterPaymentData("", "");
            payments_list.DataSource = paymentDataSource;
        }
    }
}
