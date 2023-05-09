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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            AdminDashboard dashboard = new AdminDashboard();
            dashboard.TopLevel = false;
            main_panel.Controls.Add(dashboard);
            dashboard.Show();
        }

        private void logout_btn_label_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void dashboard_btn_label_Click(object sender, EventArgs e)
        {
            dashboard_btn_panel.BackColor = Color.Honeydew;
            products_btn_panel.BackColor = Color.LightGreen;
            payments_btn_panel.BackColor = Color.LightGreen;
            staff_btn_panel.BackColor = Color.LightGreen;

            AdminDashboard adminDashboard = new AdminDashboard
            {
                TopLevel = false
            };
            main_panel.Controls.Clear();
            main_panel.Controls.Add(adminDashboard);
            adminDashboard.Show();
        }

        private void products_btn_label_Click(object sender, EventArgs e)
        {
            dashboard_btn_panel.BackColor = Color.LightGreen;
            products_btn_panel.BackColor = Color.Honeydew;
            payments_btn_panel.BackColor = Color.LightGreen;
            staff_btn_panel.BackColor = Color.LightGreen;

            Products products = new Products
            {
                TopLevel = false
            };
            main_panel.Controls.Clear();
            main_panel.Controls.Add(products);
            products.Show();
        }

        private void payments_btn_label_Click(object sender, EventArgs e)
        {
            dashboard_btn_panel.BackColor = Color.LightGreen;
            products_btn_panel.BackColor = Color.LightGreen;
            payments_btn_panel.BackColor = Color.Honeydew;
            staff_btn_panel.BackColor = Color.LightGreen;

            Payments payments = new Payments
            {
                TopLevel = false
            };
            main_panel.Controls.Clear();
            main_panel.Controls.Add(payments);
            payments.Show();
        }

        private void staff_btn_label_Click(object sender, EventArgs e)
        {
            dashboard_btn_panel.BackColor = Color.LightGreen;
            products_btn_panel.BackColor = Color.LightGreen;
            payments_btn_panel.BackColor = Color.LightGreen;
            staff_btn_panel.BackColor = Color.Honeydew;

            StaffMembers staff = new StaffMembers
            {
                TopLevel = false
            };
            main_panel.Controls.Clear();
            main_panel.Controls.Add(staff);
            staff.Show();
        }
    }
}
