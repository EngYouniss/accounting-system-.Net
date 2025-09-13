namespace system_acount
{
    partial class show_suppliers
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.delete = new System.Windows.Forms.Button();
            this.view_cus = new System.Windows.Forms.Button();
            this.add_Sup = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Iddd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.supplier_address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.supplier_phone = new System.Windows.Forms.TextBox();
            this.category = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.save_upda = new System.Windows.Forms.Button();
            this.supplier_name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(574, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(234, 228);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 19;
            this.delete.Text = "حذف";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // view_cus
            // 
            this.view_cus.Location = new System.Drawing.Point(135, 228);
            this.view_cus.Name = "view_cus";
            this.view_cus.Size = new System.Drawing.Size(75, 23);
            this.view_cus.TabIndex = 18;
            this.view_cus.Text = "حذف الكل";
            this.view_cus.UseVisualStyleBackColor = true;
            this.view_cus.Click += new System.EventHandler(this.view_cus_Click);
            // 
            // add_Sup
            // 
            this.add_Sup.Location = new System.Drawing.Point(320, 228);
            this.add_Sup.Name = "add_Sup";
            this.add_Sup.Size = new System.Drawing.Size(75, 23);
            this.add_Sup.TabIndex = 17;
            this.add_Sup.Text = "اضافة";
            this.add_Sup.UseVisualStyleBackColor = true;
            this.add_Sup.Click += new System.EventHandler(this.add_Sup_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.Iddd);
            this.groupBox2.Controls.Add(this.delete);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.view_cus);
            this.groupBox2.Controls.Add(this.add_Sup);
            this.groupBox2.Controls.Add(this.supplier_address);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.supplier_phone);
            this.groupBox2.Controls.Add(this.category);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.date);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.save_upda);
            this.groupBox2.Controls.Add(this.supplier_name);
            this.groupBox2.Location = new System.Drawing.Point(580, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 438);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "مورد جديد";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(323, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 19);
            this.label8.TabIndex = 27;
            this.label8.Text = "رقم المورد";
            // 
            // Iddd
            // 
            this.Iddd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Iddd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Iddd.Location = new System.Drawing.Point(85, 16);
            this.Iddd.Name = "Iddd";
            this.Iddd.Size = new System.Drawing.Size(233, 20);
            this.Iddd.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(324, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "العنوان";
            // 
            // supplier_address
            // 
            this.supplier_address.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.supplier_address.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.supplier_address.Location = new System.Drawing.Point(85, 137);
            this.supplier_address.Name = "supplier_address";
            this.supplier_address.Size = new System.Drawing.Size(233, 20);
            this.supplier_address.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(324, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "الهاتف";
            // 
            // supplier_phone
            // 
            this.supplier_phone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.supplier_phone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.supplier_phone.Location = new System.Drawing.Point(85, 91);
            this.supplier_phone.Name = "supplier_phone";
            this.supplier_phone.Size = new System.Drawing.Size(233, 20);
            this.supplier_phone.TabIndex = 22;
            // 
            // category
            // 
            this.category.Location = new System.Drawing.Point(85, 174);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(233, 20);
            this.category.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(324, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "الصنف";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(6, 56);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(0, 13);
            this.date.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(323, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "الاسم ";
            // 
            // save_upda
            // 
            this.save_upda.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.save_upda.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_upda.Location = new System.Drawing.Point(52, 221);
            this.save_upda.Name = "save_upda";
            this.save_upda.Size = new System.Drawing.Size(58, 35);
            this.save_upda.TabIndex = 2;
            this.save_upda.Text = "تعديل";
            this.save_upda.UseVisualStyleBackColor = false;
            this.save_upda.Click += new System.EventHandler(this.saveupda_Click);
            // 
            // supplier_name
            // 
            this.supplier_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.supplier_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.supplier_name.Location = new System.Drawing.Point(85, 49);
            this.supplier_name.Name = "supplier_name";
            this.supplier_name.Size = new System.Drawing.Size(233, 20);
            this.supplier_name.TabIndex = 0;
            // 
            // show_suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "show_suppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "show_suppliers";
            this.Load += new System.EventHandler(this.show_suppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button view_cus;
        private System.Windows.Forms.Button add_Sup;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox supplier_address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox supplier_phone;
        private System.Windows.Forms.TextBox category;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button save_upda;
        private System.Windows.Forms.TextBox supplier_name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Iddd;
    }
}