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
        private Database connection;

        public LoginForm()
        {
            InitializeComponent();
            connection = new Database();
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
                    adminForm.FormClosed += newFormClosed;
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
                string query = $"SELECT * FROM StaffTable WHERE email='{email_in.Text}'";
                DataTable memberDetails = connection.GetData(query);
                if(memberDetails.Rows.Count == 0)
                {
                    MessageBox.Show("Email address not found", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    if (memberDetails.Rows[0].IsNull("password"))
                    {
                        if(MessageBox.Show("You're not registered yet.", "Error", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            SignupForm signupForm = new SignupForm();
                            signupForm.Show();
                            this.Hide();
                        }
                    }
                    else if ((string)memberDetails.Rows[0]["password"] != password_in.Text)
                    {
                        MessageBox.Show("Incorrect Password", "Error", MessageBoxButtons.OK);
                    }
                    else
                    {
                        if ((string)memberDetails.Rows[0]["role"] == "TREATMENT")
                        {
                            PatientForm patientForm = new PatientForm((int)memberDetails.Rows[0]["id"]);
                            patientForm.FormClosed += newFormClosed;
                            patientForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            CashierForm cashierForm = new CashierForm((int)memberDetails.Rows[0]["id"]);
                            cashierForm.FormClosed += newFormClosed;
                            cashierForm.Show();
                            this.Hide();
                        }
                    }
                }
            }
        }

        private void newFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
