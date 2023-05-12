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
    public partial class AddPatientRecord : Form
    {
        private Database connection;
        private int user_id;

        public AddPatientRecord(int id)
        {
            InitializeComponent();
            connection = new Database();
            user_id = id;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (patient_name_in.Text == "" || gender_in.Text == "" || dob_in.Text == "" || contact_in.Text == "" || sick_in.Text == "" || price_in.Text == "" || discount_in.Text == "")
            {
                MessageBox.Show("You were missed some fields. Please fillout all the fields.", "Error", MessageBoxButtons.OK);
            }
            else
            {
                dob_in.Format = DateTimePickerFormat.Custom;
                dob_in.CustomFormat = "dd/MM/yyyy";
                string birthday = dob_in.Value.ToString("dd/MM/yyyy");
                string today = DateTime.Now.ToString("dd/MM/yyyy");

                string query = $"INSERT INTO PatientTable VALUES ('{patient_name_in.Text}','{gender_in.Text}','{birthday}','{contact_in.Text}',{user_id},'{sick_in.Text}',{price_in.Text},{discount_in.Text},'{today}')";
                connection.SetData(query);

                clearEntries();
            }
        }

        private void clearEntries()
        {
            patient_name_in.Text = "";
            gender_in.Text = "";
            dob_in.Text = "";
            contact_in.Text = "";
            sick_in.Text = "";
            price_in.Text = "";
            discount_in.Text = "";
        }
    }
}
