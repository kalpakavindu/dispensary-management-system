using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dispensary_management_system.Dialogs
{
    public partial class StaffMember : Form
    {
        private int editKey;
        private Database connection;

        public StaffMember(int id,bool toUpd)
        {
            InitializeComponent();
            connection = new Database();
            editKey = id;
            if(editKey == 0)
            {
                upd_btn.Visible = false;
                del_btn.Visible = false;
            }
            else
            {
                if (toUpd)
                {
                    add_btn.Visible = false;
                    loadData(editKey);
                }
                else
                {
                    add_btn.Visible = false;
                    upd_btn.Visible = false;
                    loadData(editKey);

                    first_name_in.ReadOnly = true;
                    last_name_in.ReadOnly = true;
                    email_in.ReadOnly = true;
                    contact_in.ReadOnly = true;
                }
            }
        }

        private void loadData(int key)
        {
            try
            {
                string query = $"SELECT * FROM StaffTable WHERE id={key}";
                DataTable memberDetails = connection.GetData(query);

                first_name_in.Text = (string)memberDetails.Rows[0]["first_name"];
                last_name_in.Text = (string)memberDetails.Rows[0]["last_name"];
                gender_in.SelectedItem = (string)memberDetails.Rows[0]["gender"];
                dob_in.Value = DateTime.ParseExact((string)memberDetails.Rows[0]["dob"],"dd/MM/yyyy",CultureInfo.InvariantCulture);
                email_in.Text = (string)memberDetails.Rows[0]["email"];
                contact_in.Text = (string)memberDetails.Rows[0]["contact"];
            }
            catch (Exception ex)
            {
                if(MessageBox.Show(ex.Message,"Unexpected error",MessageBoxButtons.OK) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if(first_name_in.Text == "" || last_name_in.Text == ""|| gender_in.Text == "" || email_in.Text == ""||dob_in.Text == "" || contact_in.Text == "")
            {
                MessageBox.Show("Please fillout all the fields to continue.", "Error", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    dob_in.Format = DateTimePickerFormat.Custom;
                    dob_in.CustomFormat = "dd/MM/yyyy";
                    string birthday = dob_in.Value.Date.ToString("dd/MM/yyyy");

                    string query = $"INSERT INTO StaffTable VALUES('{first_name_in.Text}','{last_name_in.Text}','{email_in.Text}','{gender_in.Text}','{birthday}','{contact_in.Text}',null)";
                    connection.SetData(query);
                    if (MessageBox.Show("Congradulations!\n\nNew Staff Member has been added successfully.", "Success", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        this.Close();
                    }
                }catch(Exception ex)
                {
                    if(MessageBox.Show(ex.Message,"Unexpected error",MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }
            }
        }

        private void upd_btn_Click(object sender, EventArgs e)
        {
            if (first_name_in.Text == "" || last_name_in.Text == "" || gender_in.Text == "" || email_in.Text == "" || dob_in.Text == "" || contact_in.Text == "")
            {
                MessageBox.Show("Please fillout all the fields to continue.", "Error", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    dob_in.Format = DateTimePickerFormat.Custom;
                    dob_in.CustomFormat = "dd/MM/yyyy";
                    string birthday = dob_in.Value.Date.ToString("dd/MM/yyyy");

                    string query = $"UPDATE StaffTable SET first_name='{first_name_in.Text}',last_name='{last_name_in.Text}',gender='{gender_in.Text}',dob='{birthday}',email='{email_in.Text}',contact='{contact_in.Text}' WHERE id={editKey}";
                    connection.SetData(query);
                    if(MessageBox.Show("Staff member detauls updated successfully.","Success",MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                catch(Exception ex)
                {
                    if (MessageBox.Show(ex.Message, "Unexpected error", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }
            }
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Delete all quotations
                string query = $"SELECT * FROM PaymentTable WHERE cashier={editKey}";
                DataTable paymentDetails = connection.GetData(query);
                foreach(DataRow r in paymentDetails.Rows)
                {
                    query = $"DELETE FROM QuotaTable WHERE payment_id={(int)r["id"]}";
                }

                // Delete all payments
                query = $"DELETE FROM PaymentTable WHERE cashier={editKey}";
                connection.SetData(query);

                // Delete staff member
                query = $"DELETE FROM StaffTable WHERE id={editKey}";
                connection.SetData(query);
                if(MessageBox.Show("Staff member deleted successfully","Success",MessageBoxButtons.OK) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                if (MessageBox.Show(ex.Message, "Unexpected error", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }
    }
}
