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
    public partial class view_users : Form
    {
        private string connectionString = "server=localhost;database=system_acount;integrated security=true";

        public view_users()
        {
            InitializeComponent();

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select_users", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    SqlConnection con = new SqlConnection(connectionString);
            //    con.Open();
            //    string query = "SELECT u_name, u_password FROM users";
            //    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            //    DataTable table = new DataTable();
            //    adapter.Fill(table);
            //    dataGridView1.DataSource = table;
            //    con.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}
        }

        private void view_users_Load(object sender, EventArgs e)
        {
        }
    }
}
