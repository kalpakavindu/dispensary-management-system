using dispensary_management_system.Dialogs;
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
    public partial class ViewPatientRecords : Form
    {
        private Database connection;
        private int user_id;

        public ViewPatientRecords(int id)
        {
            InitializeComponent();
            connection = new Database();
            user_id = id;
            loadData();
        }

        private void loadData()
        {
            string query = $"SELECT * FROM PatientTable WHERE cashier={user_id}";
            DataTable patientRecords = connection.GetData(query);

            patient_records.DataSource = patientRecords;
        }

        private void patient_records_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Patient patientDetailsModal = new Patient(Convert.ToInt32(patient_records.Rows[e.RowIndex].Cells[0].Value), false);
            patientDetailsModal.ShowDialog();
        }
    }
}
