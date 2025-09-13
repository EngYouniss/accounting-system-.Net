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
    public partial class allacounts : Form
    {
        
        SqlConnection conn=new SqlConnection("server=localhost;database=system_acount;integrated security=true");
        public string sta;
        public allacounts()
        {
            InitializeComponent();
            display_customars();
            suppli.Hide();
        }
        private void display_customars()
        {
            acount_type.Text = "Customers";

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter("select * from customars",conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void display_suppliers()
        {
            acount_type.Text = "Suppliers";

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter("select * from suppliers", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            



               


            if (acount_type.Text=="Suppliers")
            {
                iddsup.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                supplier_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                supplier_address.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                supplier_phone.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                category.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
            else
            {
                SqlCommand cmd = new SqlCommand("select stat_e from customars where customar_id=@idc", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("idc", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    sta = reader["stat_e"].ToString();
                    if (sta == "عليه")
                    {
                        overhim.Checked = true;
                    }
                    else
                   
                    {
                        forhim.Checked = true;
                    }

                    // this display the state if balance it is عليه or له

                }
                conn.Close();

                id_cus.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                customer_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                details1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                phone_number.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                balance1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
           
               
            
            
           
            

        }

       

        private void next_Click(object sender, EventArgs e)
        {
            display_suppliers();
        }

        private void العملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            display_customars();
            suppli.Hide();
            cust.Show();
        }

       

        private void الموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            display_suppliers();
            cust.Hide();
            suppli.Show();
            
        }

        private void newsup_Click(object sender, EventArgs e)
        {
            
        }

      

        private void add_suppli_Click_1(object sender, EventArgs e)
        {
            try
            {
                string query = " insert into suppliers values(@sup_name, @sup_address, @phone, @product)";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@sup_name", supplier_name.Text);
                cmd.Parameters.AddWithValue("@sup_address", supplier_address.Text);
                cmd.Parameters.AddWithValue("@phone", supplier_phone.Text);
                cmd.Parameters.AddWithValue("@product", category.Text);
                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("add successfully");
                display_suppliers();
                supplier_name.Clear();
                supplier_address.Clear();
                supplier_phone.Clear();
                category.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        void insert_cust()
        {
            DateTime dt = DateTime.Now;
            string query = "INSERT INTO customars (customar_name, details, phone_number, registration_date, balance,stat_e) " +
                       "VALUES (@custName, @detail, @phone, @date, @balance,@stat)";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@custName", customer_name.Text);
            cmd.Parameters.AddWithValue("@detail", details1.Text);
            cmd.Parameters.AddWithValue("@phone", phone_number.Text);
            cmd.Parameters.AddWithValue("@date", dt);
            cmd.Parameters.AddWithValue("@balance", Convert.ToInt32(balance1.Text));

            if (forhim.Checked)
            {
                cmd.Parameters.AddWithValue("@stat", "له");
            }
            else
            {
                cmd.Parameters.AddWithValue("@stat", "علية");

            }

            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Inserted successfully");
            display_customars();

            //this to view suppliers


            conn.Close();

            customer_name.Text = "";
            details1.Text = "";
            phone_number.Text = "";
            balance1.Text = "";
        }
        private void save_Click(object sender, EventArgs e)
        {
            insert_cust();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("delete_sup", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter[] sp = new SqlParameter[1];
                sp[0] = new SqlParameter("@sup_id", SqlDbType.Int);
                sp[0].Value = iddsup.Text;
                cmd.Parameters.AddRange(sp);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("deleted successfully");
                display_suppliers();

                customer_name.Clear();
                details1.Clear();
                phone_number.Clear();
                balance1.Clear();
                forhim.Checked = false;
                overhim.Checked = false;
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
          
        }

        private void suppli_Enter(object sender, EventArgs e)
        {
            
        }

        private void updat_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("update_supplier", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter[] param = new SqlParameter[5];
                param[0] = new SqlParameter("@sid", SqlDbType.Int);
                param[0].Value = iddsup.Text;
                param[1] = new SqlParameter("@sname", SqlDbType.NVarChar, 50);
                param[1].Value = supplier_name.Text;
                param[2] = new SqlParameter("@saddress", SqlDbType.NVarChar, 50);
                param[2].Value = supplier_address.Text;
                param[3] = new SqlParameter("@phon", SqlDbType.NVarChar, 50);
                param[3].Value = supplier_phone.Text;
                param[4] = new SqlParameter("@ptype", SqlDbType.NVarChar, 50);
                param[4].Value = category.Text;
                cmd.Parameters.AddRange(param);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show(" updated seccessfully");
                display_suppliers();
                supplier_address.Clear();
                supplier_phone.Clear();
                supplier_name.Clear();
                category.Clear();
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("update_customer", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter[] param = new SqlParameter[6];
                param[0] = new SqlParameter("@cust_id", SqlDbType.Int);
                param[0].Value = id_cus.Text;
                param[1] = new SqlParameter("@cust_name", SqlDbType.NVarChar, 50);
                param[1].Value = customer_name.Text;
                param[2] = new SqlParameter("@detail", SqlDbType.NVarChar, 50);
                param[2].Value = details1.Text;
                param[3] = new SqlParameter("@cust_phon", SqlDbType.NVarChar, 10);
                param[3].Value = phone_number.Text;
                param[4] = new SqlParameter("@balanc", SqlDbType.Int);
                param[4].Value = balance1.Text;
                param[5] = new SqlParameter("@state", SqlDbType.NVarChar, 50);
                if (forhim.Checked)
                {
                    param[5].Value = "له";

                }
                else
                {
                    param[5].Value = "علبه";

                }
                cmd.Parameters.AddRange(param);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("updated successfully");
                display_customars();
                customer_name.Clear();
                details1.Clear();
                phone_number.Clear();
                balance1.Clear();
                forhim.Checked = false;
                overhim.Checked = false;

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void acount_type_Click(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("delet_customar", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter[] sp = new SqlParameter[1];
                sp[0] = new SqlParameter("@id_c", SqlDbType.Int);
                sp[0].Value = id_cus.Text;
                cmd.Parameters.AddRange(sp);
                MessageBox.Show("You will delete the item!!", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                

                
                conn.Open();

                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("deleted successfully");
                customer_name.Clear();
                details1.Clear();
                phone_number.Clear();
                balance1.Clear();
                forhim.Checked = false;
                overhim.Checked = false;
                display_customars();            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
