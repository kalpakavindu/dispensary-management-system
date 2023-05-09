using System;
using System.Data;
using System.Windows.Forms;

namespace dispensary_management_system.Dialogs
{

    public partial class Product : Form
    {
        private Database connection;
        private int editKey;

        public Product(int id,bool toUpd)
        {
            InitializeComponent();
            connection = new Database();
            editKey = id;
            loadComboData();
            if (editKey == 0)
            {
                upd_btn.Visible = false;
            }
            else
            {
                if (toUpd)
                {
                    add_btn.Visible = false;
                    loadData(editKey);
                }
                else
                {
                    add_btn.Visible = false;
                    upd_btn.Visible = false;
                    loadData(editKey);

                    product_name_in.ReadOnly = true;
                    description_in.ReadOnly = true;
                    price_in.ReadOnly = true;
                    stock_in.ReadOnly = true;
                }
            }
        }

        private void loadData(int key)
        {
            try 
            {
                string query = $"SELECT * FROM ProductTable WHERE id={key}";
                DataTable productData = connection.GetData(query);

                query = $"SELECT name FROM CategoryTable WHERE id={(int)productData.Rows[0]["category"]}";
                DataTable categoryData = connection.GetData(query);

                product_name_in.Text = (string)productData.Rows[0]["name"];
                category_in.SelectedItem = (string)categoryData.Rows[0]["name"];
                description_in.Text = (string)productData.Rows[0]["description"];
                price_in.Text = ((int)productData.Rows[0]["price"]).ToString();
                currency_in.SelectedItem = (string)productData.Rows[0]["currency"];
                stock_in.Text = ((int)productData.Rows[0]["count"]).ToString();

            }
            catch(Exception ex) 
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

            foreach(DataRow r in categoryData.Rows)
            {
                category_in.Items.Add((string)r["name"]);
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if(product_name_in.Text == "" || description_in.Text == "" || stock_in.Text == "" || price_in.Text == "" || currency_in.Text == "" || category_in.Text == "")
            {
                MessageBox.Show("Please fillout all the fields to continue.", "Error", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    int categoryId = get_category_id(category_in.Text);

                    if(categoryId == 0)
                    {
                        MessageBox.Show("You cannot continue without selecting a correct category for this product.", "Error", MessageBoxButtons.OK);
                    }
                    else
                    {
                        string query = "INSERT INTO ProductTable VALUES ('{0}','{1}',{2},{3},{4},'{5}')";
                        query = string.Format(query, product_name_in.Text, description_in.Text, categoryId, price_in.Text, stock_in.Text, currency_in.Text);
                        connection.SetData(query);
                        if(MessageBox.Show("New product saved successfully", "Success", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                }
                catch(Exception ex)
                {
                    if(MessageBox.Show(ex.Message,"Unexpected error",MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }
            }
        }

        private void upd_btn_Click(object sender, EventArgs e)
        {
            if (product_name_in.Text == "" || description_in.Text == "" || stock_in.Text == "" || price_in.Text == "" || currency_in.Text == "" || category_in.Text == "")
            {
                MessageBox.Show("Please fillout all the fields to continue.", "Error", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    int categoryId = get_category_id(category_in.Text);

                    if (categoryId == 0)
                    {
                        MessageBox.Show("You cannot continue without selecting a correct category for this product.", "Error", MessageBoxButtons.OK);
                    }
                    else
                    {
                        string query = "UPDATE ProductTable SET name='{0}',description='{1}',price={2},count={3},currency='{4}',category={5} WHERE id={6}";
                        query = string.Format(query,product_name_in.Text,description_in.Text,price_in.Text,stock_in.Text,currency_in.Text,categoryId,editKey);
                        connection.SetData(query);
                        if (MessageBox.Show("Product details updated successfully", "Success", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
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
        
        private int get_category_id(string category_name)
        {
            string query = $"SELECT id FROM CategoryTable WHERE name='{category_name}'";
            DataTable categoryData = connection.GetData(query);

            if (categoryData.Rows.Count == 0)
            {
                if (MessageBox.Show($"There is no category named {category_in.Text} in the database.\n\n Would you like to create new category ?", "Not Found", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    query = $"INSERT INTO CategoryTable VALUES ('{category_in.Text}')";
                    connection.SetData(query);
                    query = $"SELECT id FROM CategoryTable WHERE name='{category_in.Text}'";
                    DataTable newCategoryData = connection.GetData(query);
                    return (int)newCategoryData.Rows[0]["id"];
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return (int)categoryData.Rows[0]["id"];
            }
        }
    }
}
