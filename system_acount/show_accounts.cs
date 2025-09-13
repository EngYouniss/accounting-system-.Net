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
    public partial class show_accounts : Form
    {
        //SqlConnection con = new SqlConnection("server=localhost;database=system_acount;integrated security=true");
        //SqlDataAdapter adapter;
        //DataTable dataTable;
        public show_accounts()
        {
            InitializeComponent();

           
        }
        //private void LoadSalesData()
        //{
        //    try
        //    {
        //        con.Open();
        //        adapter = new SqlDataAdapter("SELECT * FROM customars", con);
        //        dataTable = new DataTable();
        //        adapter.Fill(dataTable);
        //        con.Close();

        //        dataGridView1.DataSource = dataTable;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("حدث خطأ أثناء تحميل البيانات: " + ex.Message);
        //    }
        //}

        SqlConnection conn=new SqlConnection("server=localhost;database=system_acount;integrated security=true");
       
        private void show_accounts_Load(object sender, EventArgs e)
        {
            string sqlquer = "select* from customars";
            SqlDataAdapter ad = new SqlDataAdapter(sqlquer, conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

           

        }
    }
    
}

