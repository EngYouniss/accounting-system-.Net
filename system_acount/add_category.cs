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
    public partial class add_category : Form
    {
        private string connectionString = "server=localhost;database=system_acount;integrated security=true";

        public add_category()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string query = "insert into categories (category_name,description) values (@catName,@description)";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@catName", textBox1.Text);
                cmd.Parameters.AddWithValue("@description", textBox2.Text);

                int rowEffected = cmd.ExecuteNonQuery();

                if (rowEffected > 0)
                {
                    MessageBox.Show("Add successfully");
                    return;
                }
                else
                {
                    MessageBox.Show("Add not successfully");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
