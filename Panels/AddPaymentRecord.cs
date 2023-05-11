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
    public partial class AddPaymentRecord : Form
    {
        private Database connection;
        private int user_id;

        public AddPaymentRecord(int id)
        {
            InitializeComponent();
            connection = new Database();
            user_id = id;
        }
    }
}
