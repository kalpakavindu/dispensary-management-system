using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.PropertyGridInternal;

namespace employee_management_system.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void eye_btn_Click(object sender, EventArgs e)
        {
            if(password_in.PasswordChar ==  '*')
            {
                password_in.PasswordChar = '\0';
                eye_btn.Image = dispensary_management_system.Properties.Resources.eye_off_line_dark;
            }
            else
            {
                password_in.PasswordChar = '*';
                eye_btn.Image = dispensary_management_system.Properties.Resources.eye_line_dark;
            }
        }

        private void reg_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignupForm signupForm = new SignupForm();
            signupForm.Show();
            this.Hide();
        }
    }
}
