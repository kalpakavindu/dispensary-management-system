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
    public partial class AdminStaffMembers : Form
    {
        private Database connection;

        public AdminStaffMembers()
        {
            InitializeComponent();
            connection = new Database();
            loadData();
        }

        private void loadData()
        {
            try 
            {
                string query = "SELECT * FROM StaffTable";
                DataTable staffData = connection.GetData(query);
                staffData.Columns.Remove("password");
                member_list.DataSource = staffData;
            }
            catch(Exception ex)
            {
                if(MessageBox.Show(ex.Message,"Unexpected error",MessageBoxButtons.OK)== DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            StaffMember staffMemberAddDialog = new StaffMember(0,false);
            staffMemberAddDialog.FormClosed += staffMemberDialog_FormClosed;
            staffMemberAddDialog.ShowDialog();
        }

        private void staffMemberDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            loadData();
        }

        private void member_list_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            StaffMember staffMemberEditDialog = new StaffMember(Convert.ToInt32(member_list.Rows[e.RowIndex].Cells[0].Value.ToString()), true);
            staffMemberEditDialog.FormClosed += staffMemberDialog_FormClosed;
            staffMemberEditDialog.ShowDialog();
        }
    }
}
