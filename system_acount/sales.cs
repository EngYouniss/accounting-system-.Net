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
    public partial class sales : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;database=system_acount;integrated security=true");
        SqlDataAdapter adapter;
        DataTable dataTable;
        public sales()
        {
            InitializeComponent();
            LoadSalesData();

        }

        private void sales_Load(object sender, EventArgs e)
        {

        }
        private void LoadSalesData()
        {
            try
            {
                con.Open();
                string sql = "select* from sales";
                adapter = new SqlDataAdapter(sql, con);
                dataTable = new DataTable();
                adapter.Fill(dataTable);
                con.Close();

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل البيانات: " + ex.Message);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
