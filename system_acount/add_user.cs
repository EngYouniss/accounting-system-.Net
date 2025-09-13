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
   
    public partial class add_user : Form
    {


        private string connectionString = "server=localhost;database=system_acount;integrated security=true";
        public add_user()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string query = "insert into users (username,user_password,role) values(@username,@password,@role)";
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", textBox1.Text);
                cmd.Parameters.AddWithValue("@password", textBox2.Text);
                cmd.Parameters.AddWithValue("@role", comboBox1.SelectedItem);

                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("add seccessfully");
                    return;
                }
                else
                {
                    MessageBox.Show("invalid");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            

        }
    }
}
