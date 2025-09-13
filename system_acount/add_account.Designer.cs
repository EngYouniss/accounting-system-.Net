namespace system_acount
{
    partial class add_account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_account));
            this.suppliers = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.box = new System.Windows.Forms.Button();
            this.customers1 = new System.Windows.Forms.Button();
            this.add_cus = new System.Windows.Forms.PictureBox();
            this.add_sup = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.add_cus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_sup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // suppliers
            // 
            this.suppliers.Location = new System.Drawing.Point(521, 56);
            this.suppliers.Name = "suppliers";
            this.suppliers.Size = new System.Drawing.Size(119, 109);
            this.suppliers.TabIndex = 0;
            this.suppliers.Text = "الموردين";
            this.suppliers.UseVisualStyleBackColor = true;
            this.suppliers.Click += new System.EventHandler(this.suppliers_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 109);
            this.button1.TabIndex = 1;
            this.button1.Text = "مصروفات ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // box
            // 
            this.box.Location = new System.Drawing.Point(521, 210);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(119, 109);
            this.box.TabIndex = 2;
            this.box.Text = "الصندوق";
            this.box.UseVisualStyleBackColor = true;
            // 
            // customers1
            // 
            this.customers1.Location = new System.Drawing.Point(176, 56);
            this.customers1.Name = "customers1";
            this.customers1.Size = new System.Drawing.Size(119, 109);
            this.customers1.TabIndex = 3;
            this.customers1.Text = "العملاء";
            this.customers1.UseVisualStyleBackColor = true;
            this.customers1.Click += new System.EventHandler(this.customers1_Click);
            // 
            // add_cus
            // 
            this.add_cus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.add_cus.Image = ((System.Drawing.Image)(resources.GetObject("add_cus.Image")));
            this.add_cus.Location = new System.Drawing.Point(301, 132);
            this.add_cus.Name = "add_cus";
            this.add_cus.Size = new System.Drawing.Size(35, 33);
            this.add_cus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.add_cus.TabIndex = 22;
            this.add_cus.TabStop = false;
            this.add_cus.Click += new System.EventHandler(this.add_cus_Click);
            // 
            // add_sup
            // 
            this.add_sup.BackColor = System.Drawing.SystemColors.ControlLight;
            this.add_sup.Image = ((System.Drawing.Image)(resources.GetObject("add_sup.Image")));
            this.add_sup.Location = new System.Drawing.Point(646, 132);
            this.add_sup.Name = "add_sup";
            this.add_sup.Size = new System.Drawing.Size(35, 33);
            this.add_sup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.add_sup.TabIndex = 23;
            this.add_sup.TabStop = false;
            this.add_sup.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(301, 286);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // add_account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(849, 451);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.add_sup);
            this.Controls.Add(this.add_cus);
            this.Controls.Add(this.customers1);
            this.Controls.Add(this.box);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.suppliers);
            this.Location = new System.Drawing.Point(9, 5);
            this.Name = "add_account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add_account";
            this.Load += new System.EventHandler(this.customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.add_cus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_sup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button suppliers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button box;
        private System.Windows.Forms.Button customers1;
        private System.Windows.Forms.PictureBox add_cus;
        private System.Windows.Forms.PictureBox add_sup;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}