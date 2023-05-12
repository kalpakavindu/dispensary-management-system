namespace dispensary_management_system.Panels
{
    partial class AddPaymentRecord
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sub_total = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.quota = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.add_product_btn = new System.Windows.Forms.Button();
            this.qty_in = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.product_in = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.payment_method = new System.Windows.Forms.ComboBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.discount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.quota)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Payment Method";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(359, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Discount";
            // 
            // sub_total
            // 
            this.sub_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub_total.Location = new System.Drawing.Point(536, 335);
            this.sub_total.Name = "sub_total";
            this.sub_total.ReadOnly = true;
            this.sub_total.Size = new System.Drawing.Size(601, 24);
            this.sub_total.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(533, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Sub Total";
            // 
            // quota
            // 
            this.quota.AllowUserToAddRows = false;
            this.quota.AllowUserToDeleteRows = false;
            this.quota.AllowUserToResizeRows = false;
            this.quota.BackgroundColor = System.Drawing.SystemColors.Window;
            this.quota.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.quota.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.quota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.quota.DefaultCellStyle = dataGridViewCellStyle2;
            this.quota.Enabled = false;
            this.quota.Location = new System.Drawing.Point(18, 99);
            this.quota.MultiSelect = false;
            this.quota.Name = "quota";
            this.quota.ReadOnly = true;
            this.quota.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.quota.Size = new System.Drawing.Size(418, 375);
            this.quota.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Quotation";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.add_product_btn);
            this.panel1.Controls.Add(this.qty_in);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.product_in);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.quota);
            this.panel1.Location = new System.Drawing.Point(15, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 489);
            this.panel1.TabIndex = 30;
            // 
            // add_product_btn
            // 
            this.add_product_btn.BackColor = System.Drawing.Color.LightGreen;
            this.add_product_btn.FlatAppearance.BorderSize = 0;
            this.add_product_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.add_product_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.add_product_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_product_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_product_btn.Location = new System.Drawing.Point(314, 63);
            this.add_product_btn.Name = "add_product_btn";
            this.add_product_btn.Size = new System.Drawing.Size(122, 30);
            this.add_product_btn.TabIndex = 26;
            this.add_product_btn.Text = "Add Product";
            this.add_product_btn.UseVisualStyleBackColor = false;
            this.add_product_btn.Click += new System.EventHandler(this.add_product_btn_Click);
            // 
            // qty_in
            // 
            this.qty_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qty_in.Location = new System.Drawing.Point(314, 31);
            this.qty_in.Name = "qty_in";
            this.qty_in.Size = new System.Drawing.Size(122, 24);
            this.qty_in.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(311, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Quantity";
            // 
            // product_in
            // 
            this.product_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_in.FormattingEnabled = true;
            this.product_in.Location = new System.Drawing.Point(18, 31);
            this.product_in.Name = "product_in";
            this.product_in.Size = new System.Drawing.Size(253, 26);
            this.product_in.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Product";
            // 
            // payment_method
            // 
            this.payment_method.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment_method.FormattingEnabled = true;
            this.payment_method.Items.AddRange(new object[] {
            "VISA",
            "CASH",
            "CUPON"});
            this.payment_method.Location = new System.Drawing.Point(22, 51);
            this.payment_method.Name = "payment_method";
            this.payment_method.Size = new System.Drawing.Size(315, 26);
            this.payment_method.TabIndex = 32;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.LightGreen;
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.add_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(884, 464);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(253, 53);
            this.add_btn.TabIndex = 33;
            this.add_btn.Text = "Save Payment";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.payment_method);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.discount);
            this.panel2.Location = new System.Drawing.Point(536, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(601, 118);
            this.panel2.TabIndex = 34;
            // 
            // discount
            // 
            this.discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount.Location = new System.Drawing.Point(362, 51);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(219, 24);
            this.discount.TabIndex = 23;
            // 
            // AddPaymentRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1149, 529);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sub_total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPaymentRecord";
            this.Text = "AddPaymentRecord";
            ((System.ComponentModel.ISupportInitialize)(this.quota)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sub_total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView quota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button add_product_btn;
        private System.Windows.Forms.TextBox qty_in;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox product_in;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox payment_method;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox discount;
    }
}