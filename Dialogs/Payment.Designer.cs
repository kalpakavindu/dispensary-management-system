namespace dispensary_management_system.Dialogs
{
    partial class Payment
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
            this.label1 = new System.Windows.Forms.Label();
            this.payment_date = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.quota = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.sub_total = new System.Windows.Forms.TextBox();
            this.discount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.payment_method = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cashier = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.net_total = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cashier_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quota)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment Details";
            // 
            // payment_date
            // 
            this.payment_date.AutoSize = true;
            this.payment_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment_date.Location = new System.Drawing.Point(699, 9);
            this.payment_date.Name = "payment_date";
            this.payment_date.Size = new System.Drawing.Size(89, 20);
            this.payment_date.TabIndex = 1;
            this.payment_date.Text = "19/05/2023";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quotation";
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
            this.quota.Location = new System.Drawing.Point(17, 72);
            this.quota.MultiSelect = false;
            this.quota.Name = "quota";
            this.quota.ReadOnly = true;
            this.quota.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.quota.Size = new System.Drawing.Size(365, 412);
            this.quota.TabIndex = 3;
            this.quota.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.quota_CellDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(410, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sub Total";
            // 
            // sub_total
            // 
            this.sub_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub_total.Location = new System.Drawing.Point(413, 72);
            this.sub_total.Name = "sub_total";
            this.sub_total.ReadOnly = true;
            this.sub_total.Size = new System.Drawing.Size(369, 24);
            this.sub_total.TabIndex = 6;
            // 
            // discount
            // 
            this.discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount.Location = new System.Drawing.Point(413, 128);
            this.discount.Name = "discount";
            this.discount.ReadOnly = true;
            this.discount.Size = new System.Drawing.Size(369, 24);
            this.discount.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(410, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Discount";
            // 
            // payment_method
            // 
            this.payment_method.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment_method.Location = new System.Drawing.Point(413, 337);
            this.payment_method.Name = "payment_method";
            this.payment_method.ReadOnly = true;
            this.payment_method.Size = new System.Drawing.Size(369, 24);
            this.payment_method.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(410, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Payment Method";
            // 
            // cashier
            // 
            this.cashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashier.Location = new System.Drawing.Point(413, 395);
            this.cashier.Name = "cashier";
            this.cashier.ReadOnly = true;
            this.cashier.Size = new System.Drawing.Size(225, 24);
            this.cashier.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(410, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Cashier Name";
            // 
            // net_total
            // 
            this.net_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.net_total.Location = new System.Drawing.Point(413, 184);
            this.net_total.Name = "net_total";
            this.net_total.ReadOnly = true;
            this.net_total.Size = new System.Drawing.Size(369, 24);
            this.net_total.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(410, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Total Price";
            // 
            // cashier_btn
            // 
            this.cashier_btn.BackColor = System.Drawing.Color.LightGreen;
            this.cashier_btn.FlatAppearance.BorderSize = 0;
            this.cashier_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cashier_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cashier_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashier_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashier_btn.Location = new System.Drawing.Point(656, 375);
            this.cashier_btn.Name = "cashier_btn";
            this.cashier_btn.Size = new System.Drawing.Size(126, 44);
            this.cashier_btn.TabIndex = 15;
            this.cashier_btn.Text = "View Cashier Details";
            this.cashier_btn.UseVisualStyleBackColor = false;
            this.cashier_btn.Click += new System.EventHandler(this.cashier_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.BackColor = System.Drawing.Color.Salmon;
            this.del_btn.FlatAppearance.BorderSize = 0;
            this.del_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.del_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.del_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_btn.Location = new System.Drawing.Point(413, 453);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(369, 31);
            this.del_btn.TabIndex = 18;
            this.del_btn.Text = "Delete Payment";
            this.del_btn.UseVisualStyleBackColor = false;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.cashier_btn);
            this.Controls.Add(this.net_total);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cashier);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.payment_method);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.discount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sub_total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.quota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.payment_date);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Payment";
            this.Text = "Payment Details";
            ((System.ComponentModel.ISupportInitialize)(this.quota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label payment_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView quota;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sub_total;
        private System.Windows.Forms.TextBox discount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox payment_method;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cashier;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox net_total;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cashier_btn;
        private System.Windows.Forms.Button del_btn;
    }
}