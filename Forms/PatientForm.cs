using System;
using System.Collections.Generic;
using dispensary_management_system.Panels;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dispensary_management_system.Dialogs;

namespace dispensary_management_system.Forms
{
    public partial class PatientForm : Form
    {
        private Database connection;
        private int user_id;

        public PatientForm(int id)
        {
            InitializeComponent();
            connection = new Database();
            user_id = id;

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
                if(MessageBox.Show(ex.Message,"Unexpected Error",MessageBoxButtons.OK) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

        private void add_treatment_panel_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Honeydew;
            treatments_panel.BackColor = Color.LightGreen;

            AddPatientRecord addPatient = new AddPatientRecord(user_id)
            {
                TopLevel = false
            };
            main_panel.Controls.Clear();
            main_panel.Controls.Add(addPatient);
            addPatient.Show();
        }

        private void add_treatment_label_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Honeydew;
            treatments_panel.BackColor = Color.LightGreen;

            AddPatientRecord addPatient = new AddPatientRecord(user_id)
            {
                TopLevel = false
            };
            main_panel.Controls.Clear();
            main_panel.Controls.Add(addPatient);
            addPatient.Show();
        }

        private void treatments_panel_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Honeydew;
            add_treatment_panel.BackColor = Color.LightGreen;

            ViewPatientRecords records = new ViewPatientRecords(user_id)
            {
                TopLevel = false
            };
            main_panel.Controls.Clear();
            main_panel.Controls.Add(records);
            records.Show();
        }

        private void treatment_details_label_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Honeydew;
            add_treatment_panel.BackColor = Color.LightGreen;


            ViewPatientRecords records = new ViewPatientRecords(user_id)
            {
                TopLevel = false
            };
            main_panel.Controls.Clear();
            main_panel.Controls.Add(records);
            records.Show();
        }

        private void prof_btn_Click(object sender, EventArgs e)
        {
            StaffMember staffMember = new StaffMember(user_id, false, false);
            staffMember.ShowDialog();
        }
    }
}
