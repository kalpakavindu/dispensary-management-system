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
    public partial class ViewPaymentDetails : Form
    {
        private Database connection;
        private int user_id;

        public ViewPaymentDetails(int id)
        {
            InitializeComponent();
            connection = new Database();
            user_id = id;

            try 
            {
                string query = $"SELECT * FROM PaymentTable WHERE cashier={user_id}";
                DataTable paymentData = connection.GetData(query);
                payments.DataSource = paymentData;
            }
            catch(Exception ex) 
            {
                if(MessageBox.Show(ex.Message,"Unexpected Error",MessageBoxButtons.OK) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

        private void payments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Payment paymentDetailsModal = new Payment(Convert.ToInt32(payments.Rows[e.RowIndex].Cells[0].Value),false);
            paymentDetailsModal.ShowDialog();
        }
    }
}
