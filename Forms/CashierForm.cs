using dispensary_management_system.Dialogs;
using dispensary_management_system.Panels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dispensary_management_system.Forms
{
    public partial class CashierForm : Form
    {
        private Database connection;
        private int user_id;

        public CashierForm(int id)
        {
            InitializeComponent();
            connection = new Database();
            user_id = id;
            switchToAddPaymentPanel();

            try
            {
                string query = $"SELECT * FROM StaffTable WHERE id={id}";
                DataTable userData = connection.GetData(query);
                string first_name = (string)userData.Rows[0]["first_name"];
                string last_name = (string)userData.Rows[0]["last_name"];
                name.Text = $"{first_name} {last_name}";
            }
            catch (Exception ex)
            {
                if (MessageBox.Show(ex.Message, "Unexpected Error", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

        private void payments_panel_Click(object sender, EventArgs e)
        {
            switchToViewPaymentsPanel();
        }

        private void payment_details_label_Click(object sender, EventArgs e)
        {
            switchToViewPaymentsPanel();
        }

        private void add_payment_panel_Click(object sender, EventArgs e)
        {
            switchToAddPaymentPanel();
        }

        private void add_payment_label_Click(object sender, EventArgs e)
        {
            switchToAddPaymentPanel();
        }
    
        private void switchToAddPaymentPanel()
        {
            payments_panel.BackColor = Color.LightGreen;
            add_payment_panel.BackColor = Color.Honeydew;

            AddPaymentRecord addPaymentRecord = new AddPaymentRecord(user_id)
            {
                TopLevel = false
            };
            main_panel.Controls.Clear();
            main_panel.Controls.Add(addPaymentRecord);
            addPaymentRecord.Show();
        }
        
        private void switchToViewPaymentsPanel()
        {
            add_payment_panel.BackColor = Color.LightGreen;
            payments_panel.BackColor = Color.Honeydew;

            ViewPaymentDetails viewPaymentDetails = new ViewPaymentDetails(user_id)
            {
                TopLevel = false
            };
            main_panel.Controls.Clear();
            main_panel.Controls.Add(viewPaymentDetails);
            viewPaymentDetails.Show();
        }

        private void prof_btn_Click(object sender, EventArgs e)
        {
            StaffMember staffMember = new StaffMember(user_id, false, false);
            staffMember.ShowDialog();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
