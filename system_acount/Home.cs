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
    public partial class home : Form
    {
        SqlConnection conn=new SqlConnection("server=localhost;database=system_acount;integrated security=true");
        public home()
        {
            InitializeComponent();
            this.IsMdiContainer = true; // تحديد الفورم الرئيسية كـ MDI container


        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            //if (treeView1.SelectedNode.Text == "اضافة")
            //{
            //    add_user ad = new add_user();
            //    ad.MdiParent = this;
            //    ad.Show();
            //}
            //else if (treeView1.SelectedNode.Text == "عرض")
            //{
            //    view_users view = new view_users();
            //    view.MdiParent = this;
            //    view.Show();
            //}

            //foreach (TreeNode parentnode in treeView1.Nodes)
            //{
            //    if (treeView1.SelectedNode.Text=="اضافة")
            //    {
            //        add_product ad_prod = new add_product();
            //        ad_prod.MdiParent = this;
            //        ad_prod.Show();
            //    }
            //}

            


        }

        private void the_sales_Click(object sender, EventArgs e)
        {
            sales sa=new sales();
            sa.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            add_sale addsale = new add_sale();

            addsale.ShowDialog();

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            add_account ad=new add_account();
            ad.ShowDialog();
        }

        private void the_accounts_Click(object sender, EventArgs e)
        {
            allacounts acounts=new allacounts();
            acounts.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            add_purchase ad_pur=new add_purchase();
            ad_pur.ShowDialog();
        }

        private void purchases_Click(object sender, EventArgs e)
        {
            view_purchases viewp=new view_purchases();
                viewp.ShowDialog();

        }

        private void home_Load(object sender, EventArgs e)
        {
         
        }

        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            // احصل على العقدة المحددة
            TreeNode selectedNode = e.Node;

            // تحقق من نوع العقدة
            if (selectedNode.Level == 1) // العقدة الابن
            {
                if (selectedNode.Text == "اضافة مستخدم")
                {
                    // افتح نموذج إضافة المستخدم
                    add_user adduser = new add_user();
                    adduser.MdiParent = this;

                    adduser.Show();
                }
                else if (selectedNode.Text == "عرض المستخدمين")
                {
                    // افتح نموذج عرض المستخدم
                    view_users viewusers = new view_users();
                    viewusers.MdiParent = this;

                    viewusers.Show();
                }

                else if (selectedNode.Text == "اضافة منتج")
                {
                    // افتح نموذج عرض المستخدم
                    add_product addproduct = new add_product();
                    addproduct.MdiParent = this;

                    addproduct.Show();
                }

                else if (selectedNode.Text == "عرض المنتجات")
                {
                    // افتح نموذج عرض المستخدم
                    view_products viewproducts = new view_products();
                    viewproducts.MdiParent = this;
                    viewproducts.Show();
                }

                else if (selectedNode.Text == "اضافة صنف")
                {
                    // افتح نموذج عرض المستخدم
                    add_category adcat = new add_category();
                    adcat.MdiParent = this;
                    adcat.Show();

                }

                else if (selectedNode.Text == "عرض الاصناف")
                {
                    // افتح نموذج عرض المستخدم
                    view_categories view_Categories = new view_categories();
                    view_Categories.MdiParent = this;
                    view_Categories.Show();
                }
                else if (selectedNode.Text=="مبيعات يومية")
                {
                    day_sale_report day = new day_sale_report();
                    day.MdiParent = this;
                    day.Show();
                }
            }
        }

        private void catch_pay_Click(object sender, EventArgs e)
        {
            


        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
