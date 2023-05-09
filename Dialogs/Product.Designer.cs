namespace dispensary_management_system.Dialogs
{
    partial class Product
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
            this.label2 = new System.Windows.Forms.Label();
            this.product_name_in = new System.Windows.Forms.TextBox();
            this.description_in = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.category_in = new System.Windows.Forms.ComboBox();
            this.price_in = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.currency_in = new System.Windows.Forms.ComboBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.upd_btn = new System.Windows.Forms.Button();
            this.stock_in = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name";
            // 
            // product_name_in
            // 
            this.product_name_in.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.product_name_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_name_in.Location = new System.Drawing.Point(17, 87);
            this.product_name_in.Name = "product_name_in";
            this.product_name_in.Size = new System.Drawing.Size(275, 24);
            this.product_name_in.TabIndex = 2;
            // 
            // description_in
            // 
            this.description_in.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.description_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_in.Location = new System.Drawing.Point(17, 153);
            this.description_in.Multiline = true;
            this.description_in.Name = "description_in";
            this.description_in.Size = new System.Drawing.Size(275, 137);
            this.description_in.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Product Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(337, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Product Category";
            // 
            // category_in
            // 
            this.category_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_in.FormattingEnabled = true;
            this.category_in.Location = new System.Drawing.Point(340, 87);
            this.category_in.Name = "category_in";
            this.category_in.Size = new System.Drawing.Size(275, 26);
            this.category_in.TabIndex = 6;
            // 
            // price_in
            // 
            this.price_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_in.Location = new System.Drawing.Point(340, 153);
            this.price_in.Name = "price_in";
            this.price_in.Size = new System.Drawing.Size(193, 24);
            this.price_in.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(337, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Product Price";
            // 
            // currency_in
            // 
            this.currency_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currency_in.FormattingEnabled = true;
            this.currency_in.Items.AddRange(new object[] {
            "LKR",
            "USD",
            "AUD"});
            this.currency_in.Location = new System.Drawing.Point(538, 152);
            this.currency_in.Name = "currency_in";
            this.currency_in.Size = new System.Drawing.Size(77, 26);
            this.currency_in.TabIndex = 9;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.LightGreen;
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.add_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(340, 253);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(275, 37);
            this.add_btn.TabIndex = 10;
            this.add_btn.Text = "Add Product";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // upd_btn
            // 
            this.upd_btn.BackColor = System.Drawing.Color.LightGreen;
            this.upd_btn.FlatAppearance.BorderSize = 0;
            this.upd_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.upd_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.upd_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upd_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upd_btn.Location = new System.Drawing.Point(340, 253);
            this.upd_btn.Name = "upd_btn";
            this.upd_btn.Size = new System.Drawing.Size(275, 37);
            this.upd_btn.TabIndex = 11;
            this.upd_btn.Text = "Update Product";
            this.upd_btn.UseVisualStyleBackColor = false;
            this.upd_btn.Click += new System.EventHandler(this.upd_btn_Click);
            // 
            // stock_in
            // 
            this.stock_in.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stock_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_in.Location = new System.Drawing.Point(503, 19);
            this.stock_in.Name = "stock_in";
            this.stock_in.Size = new System.Drawing.Size(112, 24);
            this.stock_in.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(419, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Stock Count";
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(632, 329);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.stock_in);
            this.Controls.Add(this.upd_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.currency_in);
            this.Controls.Add(this.price_in);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.category_in);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.description_in);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.product_name_in);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Product";
            this.Text = "Product Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox product_name_in;
        private System.Windows.Forms.TextBox description_in;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox category_in;
        private System.Windows.Forms.TextBox price_in;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox currency_in;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button upd_btn;
        private System.Windows.Forms.TextBox stock_in;
        private System.Windows.Forms.Label label6;
    }
}