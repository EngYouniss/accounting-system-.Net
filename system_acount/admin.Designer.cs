namespace system_acount
{
    partial class admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("اضافة مستخدم");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("عرض المستخدمين");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("المستخدمين", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("اضافة منتج");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("عرض المنتجات");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("المنتجات ", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("اضافة صنف");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("عرض الاصناف");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("الاصناف", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "add_users";
            treeNode1.Text = "اضافة مستخدم";
            treeNode2.Name = "view_users";
            treeNode2.Text = "عرض المستخدمين";
            treeNode3.Name = "users";
            treeNode3.Text = "المستخدمين";
            treeNode4.Name = "add_product";
            treeNode4.Text = "اضافة منتج";
            treeNode5.Name = "view_products";
            treeNode5.Text = "عرض المنتجات";
            treeNode6.Name = "Products";
            treeNode6.Text = "المنتجات ";
            treeNode7.Name = "add_category";
            treeNode7.Text = "اضافة صنف";
            treeNode8.Name = "view_categories";
            treeNode8.Text = "عرض الاصناف";
            treeNode9.Name = "categories";
            treeNode9.Text = "الاصناف";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode9});
            this.treeView1.Size = new System.Drawing.Size(121, 450);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView1);
            this.IsMdiContainer = true;
            this.Name = "admin";
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
    }
}