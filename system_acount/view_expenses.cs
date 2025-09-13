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
    public partial class view_expenses : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;database=system_acount;integrated security=true");

        public view_expenses()
        {
            InitializeComponent();
        }
        void display_expenses()
        {
            string sql = "select* from expenses";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;


        }
        private void view_expenses_Load(object sender, EventArgs e)
        {
            display_expenses();
        }
    }
}
