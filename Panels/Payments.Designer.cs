namespace dispensary_management_system.Panels
{
    partial class Payments
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
            this.view_btn = new System.Windows.Forms.Button();
            this.payments_list = new System.Windows.Forms.DataGridView();
            this.cashier = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.time_range = new System.Windows.Forms.ComboBox();
            this.filter_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.payments_list)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Payments";
            // 
            // view_btn
            // 
            this.view_btn.BackColor = System.Drawing.Color.LightGreen;
            this.view_btn.FlatAppearance.BorderSize = 0;
            this.view_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.view_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.view_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_btn.Location = new System.Drawing.Point(763, 8);
            this.view_btn.Name = "view_btn";
            this.view_btn.Size = new System.Drawing.Size(165, 66);
            this.view_btn.TabIndex = 3;
            this.view_btn.Text = "View Payment Details";
            this.view_btn.UseVisualStyleBackColor = false;
            // 
            // payments_list
            // 
            this.payments_list.AllowUserToAddRows = false;
            this.payments_list.AllowUserToDeleteRows = false;
            this.payments_list.AllowUserToResizeRows = false;
            this.payments_list.BackgroundColor = System.Drawing.SystemColors.Window;
            this.payments_list.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.payments_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payments_list.Enabled = false;
            this.payments_list.Location = new System.Drawing.Point(12, 80);
            this.payments_list.MultiSelect = false;
            this.payments_list.Name = "payments_list";
            this.payments_list.ReadOnly = true;
            this.payments_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.payments_list.Size = new System.Drawing.Size(916, 528);
            this.payments_list.TabIndex = 4;
            // 
            // cashier
            // 
            this.cashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashier.FormattingEnabled = true;
            this.cashier.Location = new System.Drawing.Point(13, 29);
            this.cashier.Name = "cashier";
            this.cashier.Size = new System.Drawing.Size(162, 24);
            this.cashier.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cashier Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(189, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Time Range";
            // 
            // time_range
            // 
            this.time_range.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_range.FormattingEnabled = true;
            this.time_range.Items.AddRange(new object[] {
            "Today",
            "Yesterday",
            "This Week",
            "This Month",
            "This Year"});
            this.time_range.Location = new System.Drawing.Point(192, 29);
            this.time_range.Name = "time_range";
            this.time_range.Size = new System.Drawing.Size(162, 24);
            this.time_range.TabIndex = 7;
            // 
            // filter_btn
            // 
            this.filter_btn.BackColor = System.Drawing.Color.SkyBlue;
            this.filter_btn.FlatAppearance.BorderSize = 0;
            this.filter_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.filter_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.filter_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filter_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter_btn.Location = new System.Drawing.Point(373, 10);
            this.filter_btn.Name = "filter_btn";
            this.filter_btn.Size = new System.Drawing.Size(111, 43);
            this.filter_btn.TabIndex = 9;
            this.filter_btn.Text = "Filter";
            this.filter_btn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.filter_btn);
            this.panel1.Controls.Add(this.cashier);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.time_range);
            this.panel1.Location = new System.Drawing.Point(248, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 66);
            this.panel1.TabIndex = 10;
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(940, 620);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.payments_list);
            this.Controls.Add(this.view_btn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Payments";
            this.Text = "Payments";
            ((System.ComponentModel.ISupportInitialize)(this.payments_list)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button view_btn;
        private System.Windows.Forms.DataGridView payments_list;
        private System.Windows.Forms.ComboBox cashier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox time_range;
        private System.Windows.Forms.Button filter_btn;
        private System.Windows.Forms.Panel panel1;
    }
}