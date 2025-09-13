namespace system_acount
{
    partial class home
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
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("مبيعات يومية");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("مبيعات شهرية");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("مبيعات سنوية");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("التقارير", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.catch_pay = new System.Windows.Forms.Button();
            this.the_accounts = new System.Windows.Forms.Button();
            this.purchases = new System.Windows.Forms.Button();
            this.the_sales = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
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
            treeNode10.Name = "Node1";
            treeNode10.Text = "مبيعات يومية";
            treeNode11.Name = "Node2";
            treeNode11.Text = "مبيعات شهرية";
            treeNode12.Name = "Node4";
            treeNode12.Text = "مبيعات سنوية";
            treeNode13.Name = "Node0";
            treeNode13.Text = "التقارير";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode9,
            treeNode13});
            this.treeView1.Size = new System.Drawing.Size(142, 749);
            this.treeView1.TabIndex = 30;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect_1);
            // 
            // catch_pay
            // 
            this.catch_pay.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.catch_pay.ForeColor = System.Drawing.Color.White;
            this.catch_pay.Location = new System.Drawing.Point(180, 114);
            this.catch_pay.Name = "catch_pay";
            this.catch_pay.Size = new System.Drawing.Size(98, 24);
            this.catch_pay.TabIndex = 17;
            this.catch_pay.Text = "قبض // دفع";
            this.catch_pay.UseVisualStyleBackColor = false;
            this.catch_pay.Click += new System.EventHandler(this.catch_pay_Click);
            // 
            // the_accounts
            // 
            this.the_accounts.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.the_accounts.ForeColor = System.Drawing.Color.White;
            this.the_accounts.Location = new System.Drawing.Point(748, 114);
            this.the_accounts.Name = "the_accounts";
            this.the_accounts.Size = new System.Drawing.Size(98, 24);
            this.the_accounts.TabIndex = 18;
            this.the_accounts.Text = "الــحــسابات";
            this.the_accounts.UseVisualStyleBackColor = false;
            this.the_accounts.Click += new System.EventHandler(this.the_accounts_Click);
            // 
            // purchases
            // 
            this.purchases.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.purchases.ForeColor = System.Drawing.Color.White;
            this.purchases.Location = new System.Drawing.Point(1066, 108);
            this.purchases.Name = "purchases";
            this.purchases.Size = new System.Drawing.Size(98, 24);
            this.purchases.TabIndex = 19;
            this.purchases.Text = "المشتريات";
            this.purchases.UseVisualStyleBackColor = false;
            this.purchases.Click += new System.EventHandler(this.purchases_Click);
            // 
            // the_sales
            // 
            this.the_sales.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.the_sales.ForeColor = System.Drawing.Color.White;
            this.the_sales.Location = new System.Drawing.Point(498, 114);
            this.the_sales.Name = "the_sales";
            this.the_sales.Size = new System.Drawing.Size(98, 24);
            this.the_sales.TabIndex = 20;
            this.the_sales.Text = "الـــمــبيعات";
            this.the_sales.UseVisualStyleBackColor = false;
            this.the_sales.Click += new System.EventHandler(this.the_sales_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(619, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1200, 108);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1066, 21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(98, 78);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(748, 21);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(98, 78);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(498, 21);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(98, 78);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 25;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(180, 21);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(98, 78);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 26;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(882, 114);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(22, 24);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 28;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.the_sales);
            this.Controls.Add(this.purchases);
            this.Controls.Add(this.the_accounts);
            this.Controls.Add(this.catch_pay);
            this.IsMdiContainer = true;
            this.Name = "home";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button catch_pay;
        private System.Windows.Forms.Button the_accounts;
        private System.Windows.Forms.Button purchases;
        private System.Windows.Forms.Button the_sales;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}

