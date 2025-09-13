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
    public partial class login : Form
    {
        private string connectionString = "server=localhost;database=system_Acount;integrated security=true";
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    SqlConnection con = new SqlConnection(connectionString);
            //    string query = "select * from users where u_name=@username and u_password=@password";
            //    SqlCommand cmd = new SqlCommand(query, con);
            //    cmd.Parameters.AddWithValue("username", textBox1.Text);
            //    cmd.Parameters.AddWithValue("password", textBox2.Text);
            //    con.Open();
            //    SqlDataReader reader = cmd.ExecuteReader();
            //    if (reader.HasRows)
            //    {
            //        home hom = new home();
            //        hom.Show();
            //    }
            //    con.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            try
            {
                SqlConnection con = new SqlConnection(connectionString);

                string query = "SELECT * FROM users WHERE username = @username AND user_password = @password";


                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@username", textBox1.Text);
                cmd.Parameters.AddWithValue("@password", textBox2.Text);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    //reader.Read();
                    //string role=reader["role"].ToString();


                    //if (role == "admin")
                    //{
                    //    admin ad = new admin();
                    //    ad.Show();
                    //}
                    //else
                    //{
                    //    MessageBox.Show("welcom "+textBox1.Text);
                    //    home hom = new home();
                    //    hom.Show();
                    //}

                    MessageBox.Show("مرحبا" + textBox1.Text);
                        home hom = new home();
                      hom.Show();
                    
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
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
