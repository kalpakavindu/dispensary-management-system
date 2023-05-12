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
    public partial class AdminPatients : Form
    {
        private Database connection;

        public AdminPatients()
        {
            InitializeComponent();
            connection = new Database();
            loadData();
        }

        private void loadData()
        {   
            string query = "SELECT * FROM PatientTable";
            DataTable mainPaymentDetails = connection.GetData(query);
            patients_list.DataSource=mainPaymentDetails;
        }

        private void patients_list_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Patient patientDetailsModal = new Patient(Convert.ToInt32(patients_list.Rows[e.RowIndex].Cells[0].Value));
            patientDetailsModal.FormClosed += patientDetailsModal_FormClosed;
            patientDetailsModal.ShowDialog();
        }

        private void patientDetailsModal_FormClosed(object sender, FormClosedEventArgs e)
        {
            loadData();
        }
    }
}
