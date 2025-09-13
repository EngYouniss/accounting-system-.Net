namespace system_acount
{
    partial class add_customer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.overhim = new System.Windows.Forms.RadioButton();
            this.delete = new System.Windows.Forms.Button();
            this.view_cus = new System.Windows.Forms.Button();
            this.forhim = new System.Windows.Forms.RadioButton();
            this.update = new System.Windows.Forms.Button();
            this.balance1 = new System.Windows.Forms.TextBox();
            this.balance = new System.Windows.Forms.Label();
            this.phone_number = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.details = new System.Windows.Forms.Label();
            this.details1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customer_name = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.overhim);
            this.groupBox1.Controls.Add(this.delete);
            this.groupBox1.Controls.Add(this.view_cus);
            this.groupBox1.Controls.Add(this.forhim);
            this.groupBox1.Controls.Add(this.update);
            this.groupBox1.Controls.Add(this.balance1);
            this.groupBox1.Controls.Add(this.balance);
            this.groupBox1.Controls.Add(this.phone_number);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.save);
            this.groupBox1.Controls.Add(this.details);
            this.groupBox1.Controls.Add(this.details1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.customer_name);
            this.groupBox1.Location = new System.Drawing.Point(36, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 231);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "العملاء";
            // 
            // overhim
            // 
            this.overhim.AutoSize = true;
            this.overhim.Location = new System.Drawing.Point(519, 187);
            this.overhim.Name = "overhim";
            this.overhim.Size = new System.Drawing.Size(46, 17);
            this.overhim.TabIndex = 11;
            this.overhim.TabStop = true;
            this.overhim.Text = "عليه";
            this.overhim.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(232, 115);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 15;
            this.delete.Text = "حذف";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // view_cus
            // 
            this.view_cus.Location = new System.Drawing.Point(232, 156);
            this.view_cus.Name = "view_cus";
            this.view_cus.Size = new System.Drawing.Size(75, 23);
            this.view_cus.TabIndex = 14;
            this.view_cus.Text = "عرض";
            this.view_cus.UseVisualStyleBackColor = true;
            this.view_cus.Click += new System.EventHandler(this.view_cus_Click);
            // 
            // forhim
            // 
            this.forhim.AutoSize = true;
            this.forhim.Location = new System.Drawing.Point(612, 187);
            this.forhim.Name = "forhim";
            this.forhim.Size = new System.Drawing.Size(34, 17);
            this.forhim.TabIndex = 10;
            this.forhim.TabStop = true;
            this.forhim.Text = "له";
            this.forhim.UseVisualStyleBackColor = true;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(232, 73);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 13;
            this.update.Text = "تعديل";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // balance1
            // 
            this.balance1.Location = new System.Drawing.Point(371, 131);
            this.balance1.Name = "balance1";
            this.balance1.Size = new System.Drawing.Size(250, 20);
            this.balance1.TabIndex = 9;
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance.Location = new System.Drawing.Point(645, 130);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(54, 18);
            this.balance.TabIndex = 8;
            this.balance.Text = "الرصيد";
            // 
            // phone_number
            // 
            this.phone_number.Location = new System.Drawing.Point(371, 60);
            this.phone_number.Name = "phone_number";
            this.phone_number.Size = new System.Drawing.Size(250, 20);
            this.phone_number.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(627, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "رقم الهاتف";
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(232, 24);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 24);
            this.save.TabIndex = 4;
            this.save.Text = "اضافة";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // details
            // 
            this.details.AutoSize = true;
            this.details.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.details.Location = new System.Drawing.Point(642, 94);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(69, 18);
            this.details.TabIndex = 3;
            this.details.Text = "التفاصيل";
            // 
            // details1
            // 
            this.details1.Location = new System.Drawing.Point(371, 96);
            this.details1.Name = "details1";
            this.details1.Size = new System.Drawing.Size(250, 20);
            this.details1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(627, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "اسم العميل";
            // 
            // customer_name
            // 
            this.customer_name.Location = new System.Drawing.Point(371, 24);
            this.customer_name.Name = "customer_name";
            this.customer_name.Size = new System.Drawing.Size(250, 20);
            this.customer_name.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(734, 189);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // add_customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 590);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "add_customer";
            this.Text = "add_customer";
            this.Load += new System.EventHandler(this.add_customer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label details;
        private System.Windows.Forms.TextBox details1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customer_name;
        private System.Windows.Forms.TextBox phone_number;
        private System.Windows.Forms.TextBox balance1;
        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.RadioButton overhim;
        private System.Windows.Forms.RadioButton forhim;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button view_cus;
        private System.Windows.Forms.Button update;
    }
}