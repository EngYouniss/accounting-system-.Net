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
    public partial class add_supplier : Form
    {
        SqlConnection conn = new SqlConnection("server=localhost;database=system_acount;integrated security=true");
        public add_supplier()
        {
            InitializeComponent();
        }

        private void add_supplier_Load(object sender, EventArgs e)
        {

        }

        

        private void save_Click(object sender, EventArgs e)
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

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
               }
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
