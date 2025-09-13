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
    public partial class show_suppliers : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;database=system_acount;integrated security=true");
        public show_suppliers()
        {
            InitializeComponent();
        }
        private void display_suppliers()
        {
            string sql = "select * from suppliers";
           con.Open();
            SqlDataAdapter ad=new SqlDataAdapter(sql, con);
            DataTable dt= new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;



            con.Close();
        }
        private void show_suppliers_Load(object sender, EventArgs e)
        {
            display_suppliers();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Iddd.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            supplier_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            supplier_address.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            supplier_phone.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            category.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void add_Sup_Click(object sender, EventArgs e)
        {
            try
            {
                string query = " insert into suppliers values(@sup_name, @sup_address, @phone, @product)";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.AddWithValue("@sup_name", supplier_name.Text);
                cmd.Parameters.AddWithValue("@sup_address", supplier_address.Text);
                cmd.Parameters.AddWithValue("@phone", supplier_phone.Text);
                cmd.Parameters.AddWithValue("@product", category.Text);
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("add successfully");
                display_suppliers();

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void save_update_Click(object sender, EventArgs e)
        {
           
        }

        private void saveupda_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("update_supplier", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter[] param = new SqlParameter[5];
                param[0] = new SqlParameter("@sid", SqlDbType.Int);
                param[0].Value = Iddd.Text;
                param[1] = new SqlParameter("@sname", SqlDbType.NVarChar, 50);
                param[1].Value = supplier_name.Text;
                param[2] = new SqlParameter("@saddress", SqlDbType.NVarChar, 50);
                param[2].Value = supplier_address.Text;
                param[3] = new SqlParameter("@phon", SqlDbType.NVarChar, 50);
                param[3].Value = supplier_phone.Text;
                param[4] = new SqlParameter("@ptype", SqlDbType.NVarChar, 50);
                param[4].Value = category.Text;
                cmd.Parameters.AddRange(param);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(" updated seccessfully");
                display_suppliers();
                supplier_address.Clear();
                supplier_phone.Clear();
                supplier_name.Clear();
                category.Clear();
                Iddd.Clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("delete from suppliers where supplier_id=@sid", con);

                cmd.Parameters.AddWithValue("@sid", Iddd.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("deleted successfully");

                display_suppliers();
                supplier_address.Clear();
                supplier_phone.Clear();
                supplier_name.Clear();
                category.Clear();
                Iddd.Clear();

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void view_cus_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("delete from suppliers", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("deleted succesfully");
                con.Close();
                display_suppliers();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
           

        }

    }
}
