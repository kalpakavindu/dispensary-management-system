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
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void eye_btn_Click(object sender, EventArgs e)
        {
            if(password_in.PasswordChar == '*')
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

        private void eye_btn_2_Click(object sender, EventArgs e)
        {
            if (cpassword_in.PasswordChar == '*')
            {
                cpassword_in.PasswordChar = '\0';
                eye_btn_2.Image = dispensary_management_system.Properties.Resources.eye_off_line_dark;
            }
            else
            {
                cpassword_in.PasswordChar = '*';
                eye_btn_2.Image = dispensary_management_system.Properties.Resources.eye_line_dark;
            }
        }

        private void reg_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}
