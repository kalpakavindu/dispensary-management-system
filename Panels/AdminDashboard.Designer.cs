namespace dispensary_management_system.Panels
{
    partial class AdminDashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.transactions_label = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.transaction_filters = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.stock_label = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.stock_filters = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.staff_label = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.today_transaction_list = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.today_transaction_list)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.transactions_label);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.transaction_filters);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(18, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 184);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SaddleBrown;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Khaki;
            this.button1.Location = new System.Drawing.Point(187, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // transactions_label
            // 
            this.transactions_label.BackColor = System.Drawing.Color.Khaki;
            this.transactions_label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.transactions_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.transactions_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactions_label.ForeColor = System.Drawing.Color.SaddleBrown;
            this.transactions_label.Location = new System.Drawing.Point(113, 106);
            this.transactions_label.Name = "transactions_label";
            this.transactions_label.ReadOnly = true;
            this.transactions_label.Size = new System.Drawing.Size(117, 28);
            this.transactions_label.TabIndex = 3;
            this.transactions_label.Text = "36438753";
            this.transactions_label.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::dispensary_management_system.Properties.Resources.article_line_dark;
            this.pictureBox1.Location = new System.Drawing.Point(19, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // transaction_filters
            // 
            this.transaction_filters.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.transaction_filters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transaction_filters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transaction_filters.ForeColor = System.Drawing.Color.SaddleBrown;
            this.transaction_filters.FormattingEnabled = true;
            this.transaction_filters.Items.AddRange(new object[] {
            "Today",
            "Yesterday",
            "This Week",
            "This Month"});
            this.transaction_filters.Location = new System.Drawing.Point(19, 36);
            this.transaction_filters.Name = "transaction_filters";
            this.transaction_filters.Size = new System.Drawing.Size(161, 24);
            this.transaction_filters.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(15, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Transactions";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGreen;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.stock_label);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.stock_filters);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(348, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 184);
            this.panel2.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGreen;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.LightGreen;
            this.button2.Location = new System.Drawing.Point(187, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Filter";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // stock_label
            // 
            this.stock_label.BackColor = System.Drawing.Color.LightGreen;
            this.stock_label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stock_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.stock_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_label.ForeColor = System.Drawing.Color.DarkGreen;
            this.stock_label.Location = new System.Drawing.Point(113, 106);
            this.stock_label.Name = "stock_label";
            this.stock_label.ReadOnly = true;
            this.stock_label.Size = new System.Drawing.Size(117, 28);
            this.stock_label.TabIndex = 3;
            this.stock_label.Text = "36438753";
            this.stock_label.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::dispensary_management_system.Properties.Resources.stock_line_dark;
            this.pictureBox2.Location = new System.Drawing.Point(19, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // stock_filters
            // 
            this.stock_filters.BackColor = System.Drawing.Color.PaleGreen;
            this.stock_filters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stock_filters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_filters.ForeColor = System.Drawing.Color.DarkGreen;
            this.stock_filters.FormattingEnabled = true;
            this.stock_filters.Items.AddRange(new object[] {
            "Liquid Medicines",
            "Medical Equipments",
            "Tablets",
            "Other Medicines"});
            this.stock_filters.Location = new System.Drawing.Point(19, 36);
            this.stock_filters.Name = "stock_filters";
            this.stock_filters.Size = new System.Drawing.Size(161, 24);
            this.stock_filters.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(15, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Stock Count";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel3.Controls.Add(this.staff_label);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(681, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(247, 184);
            this.panel3.TabIndex = 5;
            // 
            // staff_label
            // 
            this.staff_label.BackColor = System.Drawing.Color.LightSkyBlue;
            this.staff_label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staff_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.staff_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staff_label.ForeColor = System.Drawing.Color.DarkBlue;
            this.staff_label.Location = new System.Drawing.Point(113, 106);
            this.staff_label.Name = "staff_label";
            this.staff_label.ReadOnly = true;
            this.staff_label.Size = new System.Drawing.Size(117, 28);
            this.staff_label.TabIndex = 3;
            this.staff_label.Text = "36438753";
            this.staff_label.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::dispensary_management_system.Properties.Resources.group_line_dark;
            this.pictureBox3.Location = new System.Drawing.Point(19, 78);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(69, 79);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(15, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Staff Members";
            // 
            // today_transaction_list
            // 
            this.today_transaction_list.AllowUserToAddRows = false;
            this.today_transaction_list.AllowUserToDeleteRows = false;
            this.today_transaction_list.AllowUserToResizeRows = false;
            this.today_transaction_list.BackgroundColor = System.Drawing.SystemColors.Window;
            this.today_transaction_list.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.today_transaction_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.today_transaction_list.Enabled = false;
            this.today_transaction_list.Location = new System.Drawing.Point(18, 270);
            this.today_transaction_list.MultiSelect = false;
            this.today_transaction_list.Name = "today_transaction_list";
            this.today_transaction_list.ReadOnly = true;
            this.today_transaction_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.today_transaction_list.Size = new System.Drawing.Size(615, 338);
            this.today_transaction_list.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(652, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Today total earnings";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(655, 290);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(273, 24);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(655, 350);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(273, 24);
            this.textBox2.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(652, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Today products sold";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(940, 620);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.today_transaction_list);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.today_transaction_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox transactions_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox transaction_filters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox stock_label;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox stock_filters;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox staff_label;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView today_transaction_list;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
    }
}