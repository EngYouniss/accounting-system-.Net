using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace system_acount
{
    public partial class add_product : Form
    {
        private string connectionString = "server=localhost;database=system_acount;integrated security=true";
        private Dictionary<int, string> categories = new Dictionary<int, string>();

        public add_product()
        {
            InitializeComponent();
            LoadCategories();
        }

        private void LoadCategories()
        {
            try
            {
                string categoryQuery = "SELECT category_id, category_name FROM categories";
                SqlCommand categoryCmd = new SqlCommand(categoryQuery, new SqlConnection(connectionString));
                categoryCmd.Connection.Open();
                SqlDataReader reader = categoryCmd.ExecuteReader();

                comboBox1.Items.Clear();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader.GetString(1));
                }
                reader.Close();
                categoryCmd.Connection.Close();
                comboBox1.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO products (product_name, description, sale_price,buy_price, quantity_available, category_id) " +
                                     "VALUES (@productName, @productDescription, @price,@buy_pri, @quantity, (SELECT category_id FROM categories WHERE category_name = @catName))";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand insertCmd = new SqlCommand(insertQuery, con);
                insertCmd.Parameters.AddWithValue("@productName", textBox1.Text);
                insertCmd.Parameters.AddWithValue("@productDescription", textBox4.Text);
                insertCmd.Parameters.AddWithValue("@price", textBox2.Text);
                insertCmd.Parameters.AddWithValue("@buy_pri", buy_p.Text);
                insertCmd.Parameters.AddWithValue("@quantity", textBox3.Text);
                insertCmd.Parameters.AddWithValue("@catName", comboBox1.SelectedItem.ToString());

                int rowsAffected = insertCmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Product added successfully");
                }
                else
                {
                    MessageBox.Show("Failed to add product");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}