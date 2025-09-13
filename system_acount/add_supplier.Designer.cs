namespace system_acount
{
    partial class add_supplier
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
            this.label3 = new System.Windows.Forms.Label();
            this.supplier_address = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.supplier_phone = new System.Windows.Forms.TextBox();
            this.category = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.supplier_name = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.supplier_address);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.supplier_phone);
            this.groupBox1.Controls.Add(this.category);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.save);
            this.groupBox1.Controls.Add(this.supplier_name);
            this.groupBox1.Location = new System.Drawing.Point(73, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 268);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مورد جديد";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(324, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "العنوان";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(324, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "الهاتف";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(324, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "الصنف";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(6, 56);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(0, 13);
            this.date.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "الاسم ";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.save.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(85, 212);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(58, 35);
            this.save.TabIndex = 2;
            this.save.Text = "اضافة";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
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
            // add_supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 316);
            this.Controls.Add(this.groupBox1);
            this.Name = "add_supplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "add_supplier";
            this.Load += new System.EventHandler(this.add_supplier_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox supplier_address;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox supplier_phone;
        private System.Windows.Forms.TextBox category;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox supplier_name;
    }
}