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
            loadData();
        }

        private void loadData()
        {
            string query = $"SELECT * FROM PaymentTable";
            DataTable mainPaymentCashierFDetails = connection.GetData(query);
            payments_list.DataSource = mainPaymentCashierFDetails;
        }

        private void payments_list_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Payment paymentDetails = new Payment(Convert.ToInt32(payments_list.Rows[e.RowIndex].Cells[0].Value));
            paymentDetails.FormClosed += paymentDetails_FormClosed;
            paymentDetails.ShowDialog();
        }

        private void paymentDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            loadData();
        }
    }
}
