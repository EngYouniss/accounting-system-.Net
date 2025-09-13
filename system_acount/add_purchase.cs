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
    public partial class add_purchase : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;database=system_acount;integrated security=true");

        public add_purchase()
        {
            InitializeComponent();
            LoadProducts();
            loadsupplier();
            dataGridView1.Visible = false;
        }
        public int totalpri;
        public int remanentp;
        public void LoadProducts()
        {
            try
            {
                string query = "SELECT product_id, product_name FROM products";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //string productInfo = reader["product_id"].ToString() + ": " + reader["product_name"].ToString() + " - " + reader["buy_price"].ToString();
                    productid.Items.Add(reader["product_name"]);
                    idd.Text = Convert.ToString(reader["product_id"]);


                }


                con.Close();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        //void loadprice()
        //{
        //    string query = "SELECT buy_price FROM products where product_name=@p_name";
        //    SqlCommand comman=new SqlCommand(query, con);
        //    con.Open();

        //    comman.Parameters.AddWithValue("@p_name",productid.Text);
        //    comman.ExecuteNonQuery();

        //    con.Close();


        //}
        public void loadsupplier()
        {
            string sql = "select supplier_id, supplier_name from suppliers ";
            SqlCommand com=new SqlCommand(sql, con);
            con.Open();

            SqlDataReader reader=com.ExecuteReader();
            while (reader.Read())
            {
                supplierN.Items.Add(reader["supplier_name"]);
                sup_id.Text = Convert.ToString(reader["supplier_id"]);
               
            }

            con.Close();
        }
        //private void ProductSelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (productid.SelectedIndex != -1)
        //    {
        //        string[] productInfo = productid.SelectedItem.ToString().Split(':');
        //        int price = Convert.ToInt32(productInfo[1].Split('-')[1].Trim());
        //        pricee.Text = price.ToString();

        //        CalculateTotalPrice(sender, e); // حساب الإجمالي عند تغيير المنتج
        //    }
        //}
        //private void CalculateTotalPrice(object sender, EventArgs e)
        //{
        //    if (!string.IsNullOrEmpty(quantityy.Text) && int.TryParse(quantityy.Text, out int quantity) && productid.SelectedIndex != -1)
        //    {
        //        string[] productInfo = productid.SelectedItem.ToString().Split(':');
        //        int price = Convert.ToInt32(productInfo[1].Split('-')[1].Trim());
        //        int totalPrice = price * quantity;
        //        totalprice.Text = totalPrice.ToString();
        //    }
        //}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void save_p_Click(object sender, EventArgs e)
        {
            //string[] productInfo = productid.SelectedItem.ToString().Split(':');
            //int productId = Convert.ToInt32(productInfo[0]);
            //string productNam = productInfo[1].Split('-')[0].Trim();
            //int price = Convert.ToInt32(productInfo[1].Split('-')[1].Trim());
            //int price=Convert.ToInt32(pricee.Text);
            //int quantity = Convert.ToInt32(quantityy.Text);
            //decimal totalPrice = price * quantity;


            //pricee.Text = price.ToString(); // تحديث حقل السعر بقيمة السعر المحدد
            //totalprice.Text = totalPrice.ToString(); // تحديث حقل الإجمالي بناءً على السعر والكمية

            DateTime currentDate = DateTime.Now;
            if (string.IsNullOrEmpty(pricee.Text) && string.IsNullOrEmpty(quantityy.Text))
            {
                MessageBox.Show("it is empty");
               
            }
            else
            {
                
                 totalpri = Convert.ToInt32(pricee.Text) * Convert.ToInt32(quantityy.Text);
                
                    totalprice.Text= totalpri.ToString();
                
                string insertQuery = "INSERT INTO purchases ( product_id,purchase_date, quantity_purchased, product_price, total_price,supplier_id,amount_pay,amount_remanent,notes) " +
                    "VALUES (@productid,@date, @quantity, @price, @total,@supplierid,@amountPay,@amountRemanent, @note)";

                //string que = "SELECT product_id FROM products where product_name=@pnam";
                //SqlCommand cm=new SqlCommand(que, con);
                //cm.Parameters.AddWithValue("@pnam",productid.SelectedItem );
                remanentp = Convert.ToInt32(totalprice.Text)- Convert.ToInt32(amount_p.Text);
                remanent.Text= remanentp.ToString();
                con.Open();
                //SqlDataReader readerd = cm.ExecuteReader();

                SqlCommand cmd = new SqlCommand(insertQuery, con);
                cmd.Parameters.AddWithValue("@productid", idd.Text);
                cmd.Parameters.AddWithValue("@date", currentDate);
                cmd.Parameters.AddWithValue("@quantity", quantityy.Text);
                cmd.Parameters.AddWithValue("@price", pricee.Text);
                cmd.Parameters.AddWithValue("@total", totalpri);
                cmd.Parameters.AddWithValue("@supplierid", sup_id.Text);
                cmd.Parameters.AddWithValue("@amountPay", amount_p.Text);
                cmd.Parameters.AddWithValue("@amountRemanent", remanentp);
                cmd.Parameters.AddWithValue("@note", note.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("purchase added successfully!");
            }

            dataGridView1.Visible = true;
                dataGridView1.Visible = true;
            string sqlquer = "select * from purchases";
            SqlDataAdapter ad = new SqlDataAdapter(sqlquer, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
        }
       
        private void add_purchase_Load(object sender, EventArgs e)
        {

        }
        private void displayPur()
        {

        }
        private void pricee_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(pricee.Text) && string.IsNullOrEmpty(quantityy.Text))
            {
                MessageBox.Show("it is empty");

            }
            else
            {
                if (string.IsNullOrEmpty(pricee.Text))
                {
                    totalprice.Text = "0";
                }
                else
                {
                    totalpri = Convert.ToInt32(pricee.Text) * Convert.ToInt32(quantityy.Text);
                    totalprice.Text = totalpri.ToString();
                }
              
            }
           
        }

        private void productid_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string query = "SELECT buy_price FROM products where product_name=@p_name";
            //using (SqlCommand comman = new SqlCommand(query, con))
            //{
            //    comman.Parameters.AddWithValue("@p_name", productid.SelectedItem.ToString());
            //    con.Open();
            //    SqlDataReader reader = comman.ExecuteReader();

            //    while (reader.Read())
            //    {
            //        pricee.Text = Convert.ToString(reader["buy_price"]);
            //    }

            //    con.Close();
            //}

           

        }

        private void newsup_Click(object sender, EventArgs e)
        {
            add_supplier adsuplier = new add_supplier();
            adsuplier.ShowDialog();
        }

        private void newcat_Click(object sender, EventArgs e)
        {
            add_product add_p=new add_product();
            add_p.ShowDialog();
        }

        private void amount_p_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(amount_p.Text))
            {
                remanent.Text = "0";
            }
            else
            {
                remanentp = Convert.ToInt32(totalprice.Text) - Convert.ToInt32(amount_p.Text);
                remanent.Text = remanentp.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
