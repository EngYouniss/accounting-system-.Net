namespace system_acount
{
    partial class allacounts
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
            this.acount_type = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.العملاءToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الموردينToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cust = new System.Windows.Forms.GroupBox();
            this.id_cus = new System.Windows.Forms.Label();
            this.overhim = new System.Windows.Forms.RadioButton();
            this.delete = new System.Windows.Forms.Button();
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
            this.suppli = new System.Windows.Forms.GroupBox();
            this.iddsup = new System.Windows.Forms.Label();
            this.delet = new System.Windows.Forms.Button();
            this.updat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.supplier_address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.supplier_phone = new System.Windows.Forms.TextBox();
            this.category = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.add_suppli = new System.Windows.Forms.Button();
            this.supplier_name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.cust.SuspendLayout();
            this.suppli.SuspendLayout();
            this.SuspendLayout();
            // 
            // acount_type
            // 
            this.acount_type.AutoSize = true;
            this.acount_type.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acount_type.Location = new System.Drawing.Point(488, 13);
            this.acount_type.Name = "acount_type";
            this.acount_type.Size = new System.Drawing.Size(97, 33);
            this.acount_type.TabIndex = 24;
            this.acount_type.Text = "label1";
            this.acount_type.Click += new System.EventHandler(this.acount_type_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 469);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.العملاءToolStripMenuItem,
            this.الموردينToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1208, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // العملاءToolStripMenuItem
            // 
            this.العملاءToolStripMenuItem.Name = "العملاءToolStripMenuItem";
            this.العملاءToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.العملاءToolStripMenuItem.Text = "العملاء";
            this.العملاءToolStripMenuItem.Click += new System.EventHandler(this.العملاءToolStripMenuItem_Click);
            // 
            // الموردينToolStripMenuItem
            // 
            this.الموردينToolStripMenuItem.Name = "الموردينToolStripMenuItem";
            this.الموردينToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.الموردينToolStripMenuItem.Text = "الموردين";
            this.الموردينToolStripMenuItem.Click += new System.EventHandler(this.الموردينToolStripMenuItem_Click);
            // 
            // cust
            // 
            this.cust.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cust.BackColor = System.Drawing.Color.AliceBlue;
            this.cust.Controls.Add(this.id_cus);
            this.cust.Controls.Add(this.overhim);
            this.cust.Controls.Add(this.delete);
            this.cust.Controls.Add(this.forhim);
            this.cust.Controls.Add(this.update);
            this.cust.Controls.Add(this.balance1);
            this.cust.Controls.Add(this.balance);
            this.cust.Controls.Add(this.phone_number);
            this.cust.Controls.Add(this.label3);
            this.cust.Controls.Add(this.save);
            this.cust.Controls.Add(this.details);
            this.cust.Controls.Add(this.details1);
            this.cust.Controls.Add(this.label1);
            this.cust.Controls.Add(this.customer_name);
            this.cust.Location = new System.Drawing.Point(810, 49);
            this.cust.Name = "cust";
            this.cust.Size = new System.Drawing.Size(386, 456);
            this.cust.TabIndex = 26;
            this.cust.TabStop = false;
            this.cust.Text = "العملاء";
            // 
            // id_cus
            // 
            this.id_cus.AutoSize = true;
            this.id_cus.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_cus.Location = new System.Drawing.Point(178, 278);
            this.id_cus.Name = "id_cus";
            this.id_cus.Size = new System.Drawing.Size(0, 33);
            this.id_cus.TabIndex = 31;
            this.id_cus.Visible = false;
            // 
            // overhim
            // 
            this.overhim.AutoSize = true;
            this.overhim.Location = new System.Drawing.Point(169, 193);
            this.overhim.Name = "overhim";
            this.overhim.Size = new System.Drawing.Size(46, 17);
            this.overhim.TabIndex = 11;
            this.overhim.TabStop = true;
            this.overhim.Text = "عليه";
            this.overhim.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(153, 234);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 15;
            this.delete.Text = "حذف";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // forhim
            // 
            this.forhim.AutoSize = true;
            this.forhim.Location = new System.Drawing.Point(262, 193);
            this.forhim.Name = "forhim";
            this.forhim.Size = new System.Drawing.Size(34, 17);
            this.forhim.TabIndex = 10;
            this.forhim.TabStop = true;
            this.forhim.Text = "له";
            this.forhim.UseVisualStyleBackColor = true;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(284, 234);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 13;
            this.update.Text = "تعديل";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // balance1
            // 
            this.balance1.Location = new System.Drawing.Point(21, 137);
            this.balance1.Name = "balance1";
            this.balance1.Size = new System.Drawing.Size(250, 20);
            this.balance1.TabIndex = 9;
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance.Location = new System.Drawing.Point(295, 136);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(54, 18);
            this.balance.TabIndex = 8;
            this.balance.Text = "الرصيد";
            // 
            // phone_number
            // 
            this.phone_number.Location = new System.Drawing.Point(21, 66);
            this.phone_number.Name = "phone_number";
            this.phone_number.Size = new System.Drawing.Size(250, 20);
            this.phone_number.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(277, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "رقم الهاتف";
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(35, 188);
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
            this.details.Location = new System.Drawing.Point(292, 100);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(69, 18);
            this.details.TabIndex = 3;
            this.details.Text = "التفاصيل";
            // 
            // details1
            // 
            this.details1.Location = new System.Drawing.Point(21, 102);
            this.details1.Name = "details1";
            this.details1.Size = new System.Drawing.Size(250, 20);
            this.details1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "اسم العميل";
            // 
            // customer_name
            // 
            this.customer_name.Location = new System.Drawing.Point(21, 30);
            this.customer_name.Name = "customer_name";
            this.customer_name.Size = new System.Drawing.Size(250, 20);
            this.customer_name.TabIndex = 0;
            // 
            // suppli
            // 
            this.suppli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.suppli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.suppli.Controls.Add(this.iddsup);
            this.suppli.Controls.Add(this.delet);
            this.suppli.Controls.Add(this.updat);
            this.suppli.Controls.Add(this.label2);
            this.suppli.Controls.Add(this.supplier_address);
            this.suppli.Controls.Add(this.label4);
            this.suppli.Controls.Add(this.supplier_phone);
            this.suppli.Controls.Add(this.category);
            this.suppli.Controls.Add(this.label5);
            this.suppli.Controls.Add(this.date);
            this.suppli.Controls.Add(this.label6);
            this.suppli.Controls.Add(this.add_suppli);
            this.suppli.Controls.Add(this.supplier_name);
            this.suppli.Location = new System.Drawing.Point(816, 49);
            this.suppli.Name = "suppli";
            this.suppli.Size = new System.Drawing.Size(366, 450);
            this.suppli.TabIndex = 16;
            this.suppli.TabStop = false;
            this.suppli.Text = "مورد جديد";
            this.suppli.Enter += new System.EventHandler(this.suppli_Enter);
            // 
            // iddsup
            // 
            this.iddsup.AutoSize = true;
            this.iddsup.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iddsup.Location = new System.Drawing.Point(116, 206);
            this.iddsup.Name = "iddsup";
            this.iddsup.Size = new System.Drawing.Size(0, 33);
            this.iddsup.TabIndex = 29;
            this.iddsup.Visible = false;
            // 
            // delet
            // 
            this.delet.Location = new System.Drawing.Point(98, 265);
            this.delet.Name = "delet";
            this.delet.Size = new System.Drawing.Size(75, 23);
            this.delet.TabIndex = 28;
            this.delet.Text = "حذف";
            this.delet.UseVisualStyleBackColor = true;
            this.delet.Click += new System.EventHandler(this.button2_Click);
            // 
            // updat
            // 
            this.updat.Location = new System.Drawing.Point(265, 265);
            this.updat.Name = "updat";
            this.updat.Size = new System.Drawing.Size(75, 23);
            this.updat.TabIndex = 26;
            this.updat.Text = "تعديل";
            this.updat.UseVisualStyleBackColor = true;
            this.updat.Click += new System.EventHandler(this.updat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(267, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "العنوان";
            // 
            // supplier_address
            // 
            this.supplier_address.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.supplier_address.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.supplier_address.Location = new System.Drawing.Point(28, 135);
            this.supplier_address.Name = "supplier_address";
            this.supplier_address.Size = new System.Drawing.Size(233, 20);
            this.supplier_address.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(267, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 23;
            this.label4.Text = "الهاتف";
            // 
            // supplier_phone
            // 
            this.supplier_phone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.supplier_phone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.supplier_phone.Location = new System.Drawing.Point(28, 89);
            this.supplier_phone.Name = "supplier_phone";
            this.supplier_phone.Size = new System.Drawing.Size(233, 20);
            this.supplier_phone.TabIndex = 22;
            // 
            // category
            // 
            this.category.Location = new System.Drawing.Point(28, 172);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(233, 20);
            this.category.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(267, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "الصنف";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(6, 56);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(0, 13);
            this.date.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(266, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "الاسم ";
            // 
            // add_suppli
            // 
            this.add_suppli.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.add_suppli.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_suppli.Location = new System.Drawing.Point(28, 210);
            this.add_suppli.Name = "add_suppli";
            this.add_suppli.Size = new System.Drawing.Size(58, 35);
            this.add_suppli.TabIndex = 2;
            this.add_suppli.Text = "اضافة";
            this.add_suppli.UseVisualStyleBackColor = false;
            this.add_suppli.Click += new System.EventHandler(this.add_suppli_Click_1);
            // 
            // supplier_name
            // 
            this.supplier_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.supplier_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.supplier_name.Location = new System.Drawing.Point(28, 47);
            this.supplier_name.Name = "supplier_name";
            this.supplier_name.Size = new System.Drawing.Size(233, 20);
            this.supplier_name.TabIndex = 0;
            // 
            // allacounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 616);
            this.Controls.Add(this.suppli);
            this.Controls.Add(this.cust);
            this.Controls.Add(this.acount_type);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "allacounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "allacounts";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.cust.ResumeLayout(false);
            this.cust.PerformLayout();
            this.suppli.ResumeLayout(false);
            this.suppli.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label acount_type;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem العملاءToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الموردينToolStripMenuItem;
        private System.Windows.Forms.GroupBox cust;
        private System.Windows.Forms.RadioButton overhim;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.RadioButton forhim;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox balance1;
        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.TextBox phone_number;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label details;
        private System.Windows.Forms.TextBox details1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customer_name;
        private System.Windows.Forms.GroupBox suppli;
        private System.Windows.Forms.Button delet;
        private System.Windows.Forms.Button updat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox supplier_address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox supplier_phone;
        private System.Windows.Forms.TextBox category;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button add_suppli;
        private System.Windows.Forms.TextBox supplier_name;
        private System.Windows.Forms.Label iddsup;
        private System.Windows.Forms.Label id_cus;
    }
}