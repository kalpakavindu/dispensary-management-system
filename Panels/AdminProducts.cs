using dispensary_management_system.Dialogs;
using System;
using System.Collections;
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
    public partial class AdminProducts : Form
    {
        private Database connection;

        public AdminProducts()
        {
            InitializeComponent();
            connection = new Database();
            category.SelectedItem = "All";
            loadComboData();
            loadData(0);
        }

        private void loadData(int cato)
        {
            try
            {
                string query;
                if (cato == 0)
                {
                    query = "SELECT * FROM ProductTable";
                }
                else
                {
                    query = $"SELECT * FROM ProductTable WHERE category={cato}";
                }
                DataTable productData = connection.GetData(query);
                product_list.DataSource = productData;
            }
            catch (Exception ex)
            {
                if (MessageBox.Show(ex.Message, "Unexpected error", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

        private void loadComboData()
        {
            string query = "SELECT name FROM CategoryTable";
            DataTable categoryData = connection.GetData(query);

            foreach (DataRow r in categoryData.Rows)
            {
                category.Items.Add((string)r["name"]);
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            Product productDialog = new Product(0,false);
            productDialog.FormClosed += productDialog_FormClosed;
            productDialog.ShowDialog();
        }

        private void productDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            loadData(0);
        }

        private void product_list_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Product productEditDialog = new Product(Convert.ToInt32(product_list.Rows[e.RowIndex].Cells[0].Value.ToString()), true);
            productEditDialog.FormClosed += productDialog_FormClosed;
            productEditDialog.ShowDialog();
        }

        private void filter_btn_Click(object sender, EventArgs e)
        {
            if(category.Text == "")
            {
                MessageBox.Show("Select a category from the dropdown list first.", "Error", MessageBoxButtons.OK);
            }
            else
            {
                if (category.Text == "All")
                {
                    loadData(0);
                }
                else
                {
                    try
                    {
                        string query = $"SELECT id FROM CategoryTable WHERE name='{category.Text}'";
                        DataTable categoryData = connection.GetData(query);
                        if (categoryData.Rows.Count == 0)
                        {
                            MessageBox.Show("Category is not found in the database.", "Error", MessageBoxButtons.OK);
                        }
                        else
                        {
                            loadData((int)categoryData.Rows[0]["id"]);
                        }
                    }
                    catch (Exception ex) 
                    {
                        if (MessageBox.Show(ex.Message, "Unexpected error", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            Application.Exit();
                        }
                    } 
                }
            }
        }
    }
}
