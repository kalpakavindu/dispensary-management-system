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

namespace dispensary_management_system.Dialogs
{
    public partial class CategoryDelete : Form
    {
        Database connection;
        private int del_cato_id;

        public CategoryDelete(int del_category)
        {
            InitializeComponent();
            connection = new Database();
            message.Text = "The Category you're about to delete has some products init. If you want to delete it, you must add all the products into another category.\n\nSelect a category from below dropdown and continue.";
            del_cato_id = del_category;
            loadCombo();
        }

        private void loadCombo()
        {
            try
            {
                string query = "SELECT * FROM CategoryTable";
                DataTable categoryData = connection.GetData(query);
                foreach (DataRow row in categoryData.Rows)
                {
                    if ((int)row["id"] != del_cato_id)
                    {
                        cato_combo.Items.Add((string)row["name"]);
                    }
                }
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        private void done_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if(cato_combo.Text == "")
                {
                    message.Text = "You must select a category to continue or you can cancel if you won't.";
                }
                else
                {
                    string query = $"SELECT id FROM CategoryTable WHERE name='{cato_combo.Text}'";
                    int category_id = (int)connection.GetData(query).Rows[0]["id"];
                    
                    query = $"SELECT * FROM ProductTable WHERE category={del_cato_id}";
                    DataTable productData = connection.GetData(query);

                    if (productData.Rows.Count == 0)
                    {
                        deleteCategory();
                    }
                    else
                    {
                        foreach (DataRow row in productData.Rows)
                        {
                            int productId = (int)row["id"];
                            query = $"UPDATE ProductTable SET category={category_id} WHERE id={productId}";
                        }
                        deleteCategory();
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void deleteCategory()
        {
            string query = $"DELETE FROM ProductTable WHERE category={del_cato_id}";
            connection.SetData(query);
            query = $"DELETE FROM CategoryTable WHERE id={del_cato_id}";
            connection.SetData(query);

            this.Close();
        }
    }
}
