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
    public partial class new_expenses : Form
    {
        SqlConnection con=new SqlConnection( "server=localhost;database=system_acount;integrated security=true");

        public new_expenses()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt=DateTime.Now;
            try
            {
                string query = "insert into expenses values(@name,@date,@type,@amount,@notes)";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.AddWithValue("@name", expens_name.Text);
                cmd.Parameters.AddWithValue("@date", dt);
                cmd.Parameters.AddWithValue("@type", expens_type.SelectedItem);
                cmd.Parameters.AddWithValue("@amount",amount.Text);
                cmd.Parameters.AddWithValue("@notes",notes.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("seccessfully");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
         

        }
    }
}
