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
    public partial class add_customer : Form
    {
        private string connect = "server=localhost;database=system_acount;integrated security=true";

        public add_customer()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            string query = "INSERT INTO customars (customar_name, details, phone_number, registration_date, balance,stat_e) " +
                       "VALUES (@custName, @detail, @phone, @date, @balance,@stat)";

            SqlConnection conn = new SqlConnection(connect);
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@custName", customer_name.Text);
                cmd.Parameters.AddWithValue("@detail", details1.Text);
                cmd.Parameters.AddWithValue("@phone", phone_number.Text);
                cmd.Parameters.AddWithValue("@date", dt);
               cmd.Parameters.AddWithValue("@balance", Convert.ToInt32(balance1.Text));

            if (forhim.Checked)
            {
                cmd.Parameters.AddWithValue("@stat","له");
            }
            else
            {
                cmd.Parameters.AddWithValue("@stat", "علية");

            }

            conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted successfully");

            //this to view suppliers
            if (dataGridView1.Visible==true)
            {
                view();

            }

            conn.Close();

            customer_name.Text = "";
            details1.Text = "";
            phone_number.Text = "";
            balance1.Text = "";

        }

        void view()//function to view suppliers
        {
            string sqlquer = "select* from customars";
            SqlDataAdapter ad = new SqlDataAdapter(sqlquer, connect);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void add_customer_Load(object sender, EventArgs e)
        {
            //string sqlquer = "select* from customars";
            //SqlDataAdapter ad = new SqlDataAdapter(sqlquer, connect);
            //DataTable dt = new DataTable();
            //ad.Fill(dt);
            //dataGridView1.DataSource = dt;

           
           


        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            
                customer_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                phone_number.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                details1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                balance1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
         
            
            

            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void view_cus_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            string sqlquer = "select* from customars";
            SqlDataAdapter ad = new SqlDataAdapter(sqlquer, connect);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                string query_update = "update customars set customar_name=@custname,phone_number=@phone,details=@detail,balance=@balan,stat_e=@stat where customar_id=@id  ";
                SqlConnection con = new SqlConnection(connect);
                SqlCommand sqlc = new SqlCommand(query_update, con);
                sqlc.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                sqlc.Parameters.AddWithValue("@custname", customer_name.Text);
                sqlc.Parameters.AddWithValue("@phone", phone_number.Text);
                sqlc.Parameters.AddWithValue("@detail", details1.Text);
                sqlc.Parameters.AddWithValue("@balan", balance1.Text);
                if (overhim.Checked)
                {
                    sqlc.Parameters.AddWithValue("@stat", "عليه");

                }
                else
                {
                    sqlc.Parameters.AddWithValue("@stat", "له");

                }
           

                con.Open();

                sqlc.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("updated successfully");
                view();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);    
            }
            
        }
    }
}
