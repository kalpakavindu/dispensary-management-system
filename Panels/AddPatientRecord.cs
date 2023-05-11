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
    }
}
