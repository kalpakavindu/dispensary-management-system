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

namespace dispensary_management_system.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Eye_btn_Click(object sender, EventArgs e)
        {
            if(password_in.PasswordChar ==  '*')
            {
                password_in.PasswordChar = '\0';
                eye_btn.Image = Properties.Resources.eye_off_line_dark;
            }
            else
            {
                password_in.PasswordChar = '*';
                eye_btn.Image = Properties.Resources.eye_line_dark;
            }
        }

        private void Reg_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignupForm signupForm = new SignupForm();
            signupForm.Show();
            this.Hide();
        }

        private void Signin_btn_Click(object sender, EventArgs e)
        {
            if(email_in.Text == "" || password_in.Text == "")
            {
                MessageBox.Show("You need to fillout all the fields in the form to continue forward.", "Error", MessageBoxButtons.OK);
            }
            else if(email_in.Text == "admin@email.com")
            {
                if(password_in.Text == "password")
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.FormClosed += AdminForm_FormClosed;
                    adminForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("You have entered a wrong password. Please use the correct password instead.", "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                email_in.Text = "";
                password_in.Text = "";
            }
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
