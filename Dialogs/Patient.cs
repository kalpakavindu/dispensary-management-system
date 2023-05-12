using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dispensary_management_system.Dialogs
{
    public partial class Patient : Form
    {
        private Database connection;
        private int patient_id;

        public Patient(int id, bool showDel = true)
        {
            InitializeComponent();
            connection = new Database();
            patient_id = id;
            loadData();
            del_btn.Visible = showDel;
        }

        private void loadData()
        {
            string query = $"SELECT * FROM PatientTable WHERE id={patient_id}";
            DataTable patientData = connection.GetData(query);

            patient_name_in.Text = (string)patientData.Rows[0]["name"];
            gender_in.Text = (string)patientData.Rows[0]["gender"];
            birthday_in.Text = (string)patientData.Rows[0]["dob"];
            contact_in.Text = (string)patientData.Rows[0]["contact_number"];

            int cashierId = (int)patientData.Rows[0]["cashier"];
            query = $"SELECT * FROM StaffTable WHERE id={cashierId}";
            DataTable cashierDetails = connection.GetData(query);
            string fname = (string)cashierDetails.Rows[0]["first_name"];
            string lname = (string)cashierDetails.Rows[0]["last_name"];

            cashier_in.Text = $"{fname} {lname}";
            sick_in.Text = (string)patientData.Rows[0]["sick"];
            price_in.Text = ((int)patientData.Rows[0]["price"]).ToString();
            discount_in.Text = ((int)patientData.Rows[0]["discount"]).ToString();
            treatment_date.Text = (string)patientData.Rows[0]["treatment_date"];
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"DELETE FROM PatientTable WHERE id={patient_id}";
                connection.SetData(query);
                this.Close();
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
