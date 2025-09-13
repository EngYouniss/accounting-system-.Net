using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace system_acount
{
    public partial class home2 : Form
    {
        public home2()
        {
            InitializeComponent();
        }

        private void the_sales_Click(object sender, EventArgs e)
        {
            sales sa = new sales();
            sa.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            add_sale addsale = new add_sale();
            addsale.Show();
        }
    }
}
