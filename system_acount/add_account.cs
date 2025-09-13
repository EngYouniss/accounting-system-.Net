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
    public partial class add_account : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;database=system_acount;integrated security=true");

        public add_account()
        {
            InitializeComponent();
        }

        private void the_sales_Click(object sender, EventArgs e)
        {

        }

        private void catch_pay_Click(object sender, EventArgs e)
        {

        }

        private void customers_Load(object sender, EventArgs e)
        {

        }

        private void customers1_Click(object sender, EventArgs e)
        {

            show_accounts cusss = new show_accounts();
            cusss.Show();


        }

        private void add_cus_Click(object sender, EventArgs e)
        {
            add_customer cus=new add_customer();
            cus.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            add_supplier ad_sup=new add_supplier();
            ad_sup.Show();
        }

        private void suppliers_Click(object sender, EventArgs e)
        {
            show_suppliers suppli = new show_suppliers();
            suppli.Show();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            view_expenses exp=new view_expenses();
            exp.Show();
            


        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            new_expenses exp=new new_expenses();
            exp.Show();
        }
    }
}
