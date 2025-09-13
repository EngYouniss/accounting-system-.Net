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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {

        }

            private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
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
                   add_category adcat=new add_category();
                    adcat.MdiParent = this;
                    adcat.Show();

                }

                else if (selectedNode.Text == "عرض الاصناف")
                {
                    // افتح نموذج عرض المستخدم
                   view_categories view_Categories=new view_categories();
                    view_Categories.MdiParent = this;
                    view_Categories.Show();
                }
            }
        }
    }
}
