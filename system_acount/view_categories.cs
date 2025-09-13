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
    public partial class view_categories : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;database=system_acount;integrated security=true");

        public view_categories()
        {
            InitializeComponent();
            display_categories();
        }
        void display_categories()
        {
            try
            {
                string sql = "select * from categories";
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
