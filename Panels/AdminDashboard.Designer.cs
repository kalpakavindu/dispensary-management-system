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
            this.transaction_filter_btn = new System.Windows.Forms.Button();
            this.transactions_label = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.transaction_filters = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.stock_filter_btn = new System.Windows.Forms.Button();
            this.stock_label = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.stock_filters = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.staff_label = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.category_list = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.total_earnings = new System.Windows.Forms.TextBox();
            this.products_sold = new System.Windows.Forms.TextBox();
            this.label100 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.del_cato_btn = new System.Windows.Forms.Button();
            this.upd_cato_btn = new System.Windows.Forms.Button();
            this.add_cato_btn = new System.Windows.Forms.Button();
            this.category_name_in = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.category_list)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
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
            this.panel1.Controls.Add(this.transaction_filter_btn);
            this.panel1.Controls.Add(this.transactions_label);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.transaction_filters);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(18, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 184);
            this.panel1.TabIndex = 1;
            // 
            // transaction_filter_btn
            // 
            this.transaction_filter_btn.BackColor = System.Drawing.Color.SaddleBrown;
            this.transaction_filter_btn.FlatAppearance.BorderSize = 0;
            this.transaction_filter_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transaction_filter_btn.ForeColor = System.Drawing.Color.Khaki;
            this.transaction_filter_btn.Location = new System.Drawing.Point(187, 36);
            this.transaction_filter_btn.Name = "transaction_filter_btn";
            this.transaction_filter_btn.Size = new System.Drawing.Size(43, 23);
            this.transaction_filter_btn.TabIndex = 4;
            this.transaction_filter_btn.Text = "Filter";
            this.transaction_filter_btn.UseVisualStyleBackColor = false;
            this.transaction_filter_btn.Click += new System.EventHandler(this.transaction_filter_btn_Click);
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
            "All The Time",
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
            this.panel2.Controls.Add(this.stock_filter_btn);
            this.panel2.Controls.Add(this.stock_label);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.stock_filters);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(348, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 184);
            this.panel2.TabIndex = 4;
            // 
            // stock_filter_btn
            // 
            this.stock_filter_btn.BackColor = System.Drawing.Color.DarkGreen;
            this.stock_filter_btn.FlatAppearance.BorderSize = 0;
            this.stock_filter_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stock_filter_btn.ForeColor = System.Drawing.Color.LightGreen;
            this.stock_filter_btn.Location = new System.Drawing.Point(187, 37);
            this.stock_filter_btn.Name = "stock_filter_btn";
            this.stock_filter_btn.Size = new System.Drawing.Size(43, 23);
            this.stock_filter_btn.TabIndex = 5;
            this.stock_filter_btn.Text = "Filter";
            this.stock_filter_btn.UseVisualStyleBackColor = false;
            this.stock_filter_btn.Click += new System.EventHandler(this.stock_filter_btn_Click);
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
            "All"});
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
            // category_list
            // 
            this.category_list.AllowUserToAddRows = false;
            this.category_list.AllowUserToDeleteRows = false;
            this.category_list.AllowUserToResizeRows = false;
            this.category_list.BackgroundColor = System.Drawing.SystemColors.Window;
            this.category_list.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.category_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.category_list.Location = new System.Drawing.Point(19, 44);
            this.category_list.MultiSelect = false;
            this.category_list.Name = "category_list";
            this.category_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.category_list.Size = new System.Drawing.Size(285, 285);
            this.category_list.TabIndex = 6;
            this.category_list.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.category_list_CellDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total earnings";
            // 
            // total_earnings
            // 
            this.total_earnings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.total_earnings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_earnings.Location = new System.Drawing.Point(16, 85);
            this.total_earnings.Name = "total_earnings";
            this.total_earnings.ReadOnly = true;
            this.total_earnings.Size = new System.Drawing.Size(259, 24);
            this.total_earnings.TabIndex = 8;
            // 
            // products_sold
            // 
            this.products_sold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.products_sold.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.products_sold.Location = new System.Drawing.Point(16, 145);
            this.products_sold.Name = "products_sold";
            this.products_sold.ReadOnly = true;
            this.products_sold.Size = new System.Drawing.Size(259, 24);
            this.products_sold.TabIndex = 10;
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label100.Location = new System.Drawing.Point(13, 125);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(89, 16);
            this.label100.TabIndex = 9;
            this.label100.Text = "Products sold";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Honeydew;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.del_cato_btn);
            this.panel4.Controls.Add(this.upd_cato_btn);
            this.panel4.Controls.Add(this.add_cato_btn);
            this.panel4.Controls.Add(this.category_name_in);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.category_list);
            this.panel4.Location = new System.Drawing.Point(18, 257);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(593, 351);
            this.panel4.TabIndex = 11;
            // 
            // del_cato_btn
            // 
            this.del_cato_btn.BackColor = System.Drawing.Color.Salmon;
            this.del_cato_btn.FlatAppearance.BorderSize = 0;
            this.del_cato_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.del_cato_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.del_cato_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_cato_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_cato_btn.Location = new System.Drawing.Point(313, 295);
            this.del_cato_btn.Name = "del_cato_btn";
            this.del_cato_btn.Size = new System.Drawing.Size(263, 34);
            this.del_cato_btn.TabIndex = 13;
            this.del_cato_btn.Text = "Remove Category";
            this.del_cato_btn.UseVisualStyleBackColor = false;
            this.del_cato_btn.Click += new System.EventHandler(this.del_cato_btn_Click);
            // 
            // upd_cato_btn
            // 
            this.upd_cato_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.upd_cato_btn.FlatAppearance.BorderSize = 0;
            this.upd_cato_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.upd_cato_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.upd_cato_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upd_cato_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upd_cato_btn.Location = new System.Drawing.Point(313, 255);
            this.upd_cato_btn.Name = "upd_cato_btn";
            this.upd_cato_btn.Size = new System.Drawing.Size(263, 34);
            this.upd_cato_btn.TabIndex = 12;
            this.upd_cato_btn.Text = "Update Category";
            this.upd_cato_btn.UseVisualStyleBackColor = false;
            this.upd_cato_btn.Click += new System.EventHandler(this.upd_cato_btn_Click);
            // 
            // add_cato_btn
            // 
            this.add_cato_btn.BackColor = System.Drawing.Color.LightGreen;
            this.add_cato_btn.FlatAppearance.BorderSize = 0;
            this.add_cato_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.add_cato_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.add_cato_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_cato_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_cato_btn.Location = new System.Drawing.Point(313, 215);
            this.add_cato_btn.Name = "add_cato_btn";
            this.add_cato_btn.Size = new System.Drawing.Size(263, 34);
            this.add_cato_btn.TabIndex = 11;
            this.add_cato_btn.Text = "Add Category";
            this.add_cato_btn.UseVisualStyleBackColor = false;
            this.add_cato_btn.Click += new System.EventHandler(this.add_cato_btn_Click);
            // 
            // category_name_in
            // 
            this.category_name_in.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.category_name_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_name_in.Location = new System.Drawing.Point(313, 64);
            this.category_name_in.Name = "category_name_in";
            this.category_name_in.Size = new System.Drawing.Size(263, 24);
            this.category_name_in.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(310, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Category Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Product Categories";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.total_earnings);
            this.panel5.Controls.Add(this.products_sold);
            this.panel5.Controls.Add(this.label100);
            this.panel5.Location = new System.Drawing.Point(635, 257);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(293, 221);
            this.panel5.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Today Summery";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(940, 620);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
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
            ((System.ComponentModel.ISupportInitialize)(this.category_list)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
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
        private System.Windows.Forms.DataGridView category_list;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox total_earnings;
        private System.Windows.Forms.Button transaction_filter_btn;
        private System.Windows.Forms.Button stock_filter_btn;
        private System.Windows.Forms.TextBox products_sold;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button del_cato_btn;
        private System.Windows.Forms.Button upd_cato_btn;
        private System.Windows.Forms.Button add_cato_btn;
        private System.Windows.Forms.TextBox category_name_in;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
    }
}