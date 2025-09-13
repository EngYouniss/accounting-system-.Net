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
    public partial class add_sale : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;database=system_acount;integrated security=true");

        public add_sale()
        {
            InitializeComponent();
            LoadProducts();
            productNamee.SelectedIndexChanged += new EventHandler(ProductSelectedIndexChanged);
            quantityy.TextChanged += new EventHandler(CalculateTotalPrice); // إضافة معالج الحدث لحساب الإجمالي عند تغيير الكمية
        }

        private void LoadProducts()
        {
            string query = "SELECT product_id, product_name, buy_price FROM products";
            SqlCommand cm = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = cm.ExecuteReader();
            while (reader.Read())
            {
                string  productInfor =  
                    ": " + reader["product_id"].ToString() + " - " + reader["buy_price"].ToString();
                string p_name = reader["product_name"].ToString();
                productNamee.Items.Add(p_name);
            }
            con.Close();
        }

        private void ProductSelectedIndexChanged(object sender, EventArgs e)
        {
            if (productNamee.SelectedIndex != -1)
            {
                string productInfo = productNamee.SelectedItem.ToString();
                int price = Convert.ToInt32(productInfo[1]);
                pricee.Text = price.ToString();

                CalculateTotalPrice(sender, e); // حساب الإجمالي عند تغيير المنتج
            }
        }

        private void CalculateTotalPrice(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(quantityy.Text) && int.TryParse(quantityy.Text, out int quantity) && productNamee.SelectedIndex != -1)
            {
                string productInfo = productNamee.SelectedItem.ToString();
                int price = Convert.ToInt32(productInfo[1]);
                int totalPrice = price * quantity;
                totalprice.Text = totalPrice.ToString();
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            string query = "SELECT product_id ,buy_price from products where product_name=@pname";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.Parameters.AddWithValue("@pname", productNamee.SelectedItem);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                int productId = Convert.ToInt32(reader["product_id"]);
                int price = Convert.ToInt32(reader["buy_price"]);// قم بتعريف السعر هنا

                // قم بتعريف السعر والكمية هنا

                int quantity = Convert.ToInt32(quantityy.Text);
                decimal totalPrice = price * quantity;

                pricee.Text = price.ToString();
                totalprice.Text = totalPrice.ToString();

                DateTime currentDate = DateTime.Now;

                string insertQuery = "INSERT INTO sales (sale_date, product_id, quantity_Sold, sale_price, total_sale, nots, customer_name) " +
                    "VALUES (@date, @product_id, @quantity, @price, @total, @note, @customer)";
                SqlCommand cd = new SqlCommand(insertQuery, con);

                cd.Parameters.AddWithValue("@date", currentDate);
                cd.Parameters.AddWithValue("@product_id", productId);
                cd.Parameters.AddWithValue("@quantity", quantity);
                cd.Parameters.AddWithValue("@price", price);
                cd.Parameters.AddWithValue("@total", totalPrice);
                cd.Parameters.AddWithValue("@note", note.Text);
                cd.Parameters.AddWithValue("@customer", customerName.Text);

                reader.Close();
                cd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Sale added successfully!");
            }
            else
            {
                MessageBox.Show("Product not found!");
            }
        }

        private void add_sale_Load(object sender, EventArgs e)
        {

        }

        private void pricee_TextChanged(object sender, EventArgs e)
        {
        }
    }
}