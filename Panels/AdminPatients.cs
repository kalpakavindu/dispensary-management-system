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
    public partial class AdminPatients : Form
    {
        private Database connection;

        public AdminPatients()
        {
            InitializeComponent();
            connection = new Database();
            loadCombos();
            time_range.SelectedItem = "All the Time";
            DataTable patientData = filterPatientData("", "");
            patients_list.DataSource = patientData;
        }

        private void loadCombos()
        {
            string query = $"SELECT first_name FROM StaffTable";
            DataTable staffData = connection.GetData(query);

            foreach (DataRow dr in staffData.Rows)
            {
                cashier.Items.Add((string)dr["first_name"]);
            }
        }

        private DataTable filterPatientData(string filterCashierName, string filterTimeRange)
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
                            query = $"SELECT * FROM PatientTable WHERE treatment_date='{today}'";
                            break;
                        default:
                            string yesterday = DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy");
                            query = $"SELECT * FROM PatientTable WHERE treatment_date='{yesterday}'";
                            break;
                    }
                    DataTable paymentDetails = connection.GetData(query);
                    return paymentDetails;
                }
                else
                {
                    query = "SELECT * FROM PatientTable";
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
                                if ((string)row["treatment_date"] == date)
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
                                if ((string)row["treatment_date"] == date)
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

                query = $"SELECT * FROM PatientTable WHERE cashier={cashierId}";
                DataTable mainPaymentCashierFDetails = connection.GetData(query);
                DataTable paymentCashierFDetails = mainPaymentCashierFDetails.Copy();

                if (filterTimeRange == "Today" || filterTimeRange == "Yesterday")
                {
                    switch (filterTimeRange)
                    {
                        case "Today":
                            string today = DateTime.Now.ToString("dd/MM/yyyy");
                            foreach (DataRow r in mainPaymentCashierFDetails.Rows)
                            {
                                if ((string)r["treatment_date"] != today)
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
                                if ((string)r["treatment_date"] != yesterday)
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
                    if (filterTimeRange == "This Week")
                    {
                        paymentCashierFDetails.Rows.Clear();
                        for (int i = 0; i < 7; i++)
                        {
                            string date = DateTime.Now.AddDays(-i).ToString("dd/MM/yyyy");
                            foreach (DataRow row in mainPaymentCashierFDetails.Rows)
                            {
                                if ((string)row["treatment_date"] == date)
                                {
                                    paymentCashierFDetails.ImportRow(row);
                                }
                            }
                        }
                        return paymentCashierFDetails;
                    }
                    else if (filterTimeRange == "This Month")
                    {
                        paymentCashierFDetails.Rows.Clear();
                        for (int i = 0; i < 30; i++)
                        {
                            string date = DateTime.Now.AddDays(-i).ToString("dd/MM/yyyy");
                            foreach (DataRow row in mainPaymentCashierFDetails.Rows)
                            {
                                if ((string)row["treatment_date"] == date)
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
            DataTable patientData = filterPatientData(cashier.Text, time_range.Text);
            patients_list.DataSource = patientData;
        }

        private void patients_list_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Patient patientDetailsModal = new Patient(Convert.ToInt32(patients_list.Rows[e.RowIndex].Cells[0].Value));
            patientDetailsModal.FormClosed += patientDetailsModal_FormClosed;
            patientDetailsModal.ShowDialog();
        }

        private void patientDetailsModal_FormClosed(object sender, FormClosedEventArgs e)
        {
            cashier.Text = "";
            time_range.SelectedItem = "All the Time";
            DataTable patientData = filterPatientData("", "");
            patients_list.DataSource = patientData;
        }
    }
}
