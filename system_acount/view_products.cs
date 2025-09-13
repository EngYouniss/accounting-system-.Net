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
    public partial class view_products : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;database=system_acount;integrated security=true");

        public view_products()
        {
            InitializeComponent();
        }

        private void view_products_Load(object sender, EventArgs e)
        {
            display_products();

        }
        void display_products()
        {

            try
            {
                string sql = "select * from products";
                con.Open();
                SqlDataAdapter ad = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

    }
}
