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
    }
}
