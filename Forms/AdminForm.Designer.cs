namespace dispensary_management_system.Forms
{
    partial class AdminForm
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
            this.navigation_panel = new System.Windows.Forms.Panel();
            this.treatments_panel = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.treatments_label = new System.Windows.Forms.Label();
            this.logout_btn_panel = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.logout_btn_label = new System.Windows.Forms.Label();
            this.staff_btn_panel = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.staff_btn_label = new System.Windows.Forms.Label();
            this.payments_btn_panel = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.payments_btn_label = new System.Windows.Forms.Label();
            this.products_btn_panel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.products_btn_label = new System.Windows.Forms.Label();
            this.dashboard_btn_panel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dashboard_btn_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.main_panel = new System.Windows.Forms.Panel();
            this.navigation_panel.SuspendLayout();
            this.treatments_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.logout_btn_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.staff_btn_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.payments_btn_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.products_btn_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.dashboard_btn_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // navigation_panel
            // 
            this.navigation_panel.BackColor = System.Drawing.Color.LightGreen;
            this.navigation_panel.Controls.Add(this.treatments_panel);
            this.navigation_panel.Controls.Add(this.logout_btn_panel);
            this.navigation_panel.Controls.Add(this.staff_btn_panel);
            this.navigation_panel.Controls.Add(this.payments_btn_panel);
            this.navigation_panel.Controls.Add(this.products_btn_panel);
            this.navigation_panel.Controls.Add(this.dashboard_btn_panel);
            this.navigation_panel.Controls.Add(this.pictureBox1);
            this.navigation_panel.Controls.Add(this.label1);
            this.navigation_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigation_panel.Location = new System.Drawing.Point(0, 0);
            this.navigation_panel.Name = "navigation_panel";
            this.navigation_panel.Size = new System.Drawing.Size(227, 620);
            this.navigation_panel.TabIndex = 0;
            // 
            // treatments_panel
            // 
            this.treatments_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.treatments_panel.BackColor = System.Drawing.Color.LightGreen;
            this.treatments_panel.Controls.Add(this.pictureBox7);
            this.treatments_panel.Controls.Add(this.treatments_label);
            this.treatments_panel.Location = new System.Drawing.Point(0, 254);
            this.treatments_panel.Name = "treatments_panel";
            this.treatments_panel.Size = new System.Drawing.Size(227, 46);
            this.treatments_panel.TabIndex = 6;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::dispensary_management_system.Properties.Resources.group_line_dark;
            this.pictureBox7.Location = new System.Drawing.Point(19, 7);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(34, 32);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 1;
            this.pictureBox7.TabStop = false;
            // 
            // treatments_label
            // 
            this.treatments_label.AutoSize = true;
            this.treatments_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treatments_label.Location = new System.Drawing.Point(99, 14);
            this.treatments_label.Name = "treatments_label";
            this.treatments_label.Size = new System.Drawing.Size(114, 18);
            this.treatments_label.TabIndex = 0;
            this.treatments_label.Text = "Patient Records";
            this.treatments_label.Click += new System.EventHandler(this.treatments_label_Click);
            // 
            // logout_btn_panel
            // 
            this.logout_btn_panel.BackColor = System.Drawing.Color.LightGreen;
            this.logout_btn_panel.Controls.Add(this.pictureBox6);
            this.logout_btn_panel.Controls.Add(this.logout_btn_label);
            this.logout_btn_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logout_btn_panel.Location = new System.Drawing.Point(0, 574);
            this.logout_btn_panel.Name = "logout_btn_panel";
            this.logout_btn_panel.Size = new System.Drawing.Size(227, 46);
            this.logout_btn_panel.TabIndex = 6;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::dispensary_management_system.Properties.Resources.logout_line_dark;
            this.pictureBox6.Location = new System.Drawing.Point(19, 7);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(34, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            // 
            // logout_btn_label
            // 
            this.logout_btn_label.AutoSize = true;
            this.logout_btn_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn_label.Location = new System.Drawing.Point(159, 14);
            this.logout_btn_label.Name = "logout_btn_label";
            this.logout_btn_label.Size = new System.Drawing.Size(54, 18);
            this.logout_btn_label.TabIndex = 0;
            this.logout_btn_label.Text = "Logout";
            this.logout_btn_label.Click += new System.EventHandler(this.logout_btn_label_Click);
            // 
            // staff_btn_panel
            // 
            this.staff_btn_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.staff_btn_panel.BackColor = System.Drawing.Color.LightGreen;
            this.staff_btn_panel.Controls.Add(this.pictureBox5);
            this.staff_btn_panel.Controls.Add(this.staff_btn_label);
            this.staff_btn_panel.Location = new System.Drawing.Point(0, 306);
            this.staff_btn_panel.Name = "staff_btn_panel";
            this.staff_btn_panel.Size = new System.Drawing.Size(227, 46);
            this.staff_btn_panel.TabIndex = 5;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::dispensary_management_system.Properties.Resources.group_line_dark;
            this.pictureBox5.Location = new System.Drawing.Point(19, 7);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(34, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // staff_btn_label
            // 
            this.staff_btn_label.AutoSize = true;
            this.staff_btn_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staff_btn_label.Location = new System.Drawing.Point(175, 14);
            this.staff_btn_label.Name = "staff_btn_label";
            this.staff_btn_label.Size = new System.Drawing.Size(38, 18);
            this.staff_btn_label.TabIndex = 0;
            this.staff_btn_label.Text = "Staff";
            this.staff_btn_label.Click += new System.EventHandler(this.staff_btn_label_Click);
            // 
            // payments_btn_panel
            // 
            this.payments_btn_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.payments_btn_panel.BackColor = System.Drawing.Color.LightGreen;
            this.payments_btn_panel.Controls.Add(this.pictureBox4);
            this.payments_btn_panel.Controls.Add(this.payments_btn_label);
            this.payments_btn_panel.Location = new System.Drawing.Point(0, 202);
            this.payments_btn_panel.Name = "payments_btn_panel";
            this.payments_btn_panel.Size = new System.Drawing.Size(227, 46);
            this.payments_btn_panel.TabIndex = 4;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::dispensary_management_system.Properties.Resources.article_line_dark;
            this.pictureBox4.Location = new System.Drawing.Point(19, 7);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // payments_btn_label
            // 
            this.payments_btn_label.AutoSize = true;
            this.payments_btn_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payments_btn_label.Location = new System.Drawing.Point(139, 14);
            this.payments_btn_label.Name = "payments_btn_label";
            this.payments_btn_label.Size = new System.Drawing.Size(74, 18);
            this.payments_btn_label.TabIndex = 0;
            this.payments_btn_label.Text = "Payments";
            this.payments_btn_label.Click += new System.EventHandler(this.payments_btn_label_Click);
            // 
            // products_btn_panel
            // 
            this.products_btn_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.products_btn_panel.BackColor = System.Drawing.Color.LightGreen;
            this.products_btn_panel.Controls.Add(this.pictureBox3);
            this.products_btn_panel.Controls.Add(this.products_btn_label);
            this.products_btn_panel.Location = new System.Drawing.Point(0, 150);
            this.products_btn_panel.Name = "products_btn_panel";
            this.products_btn_panel.Size = new System.Drawing.Size(227, 46);
            this.products_btn_panel.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::dispensary_management_system.Properties.Resources.stock_line_dark;
            this.pictureBox3.Location = new System.Drawing.Point(19, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // products_btn_label
            // 
            this.products_btn_label.AutoSize = true;
            this.products_btn_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.products_btn_label.Location = new System.Drawing.Point(145, 14);
            this.products_btn_label.Name = "products_btn_label";
            this.products_btn_label.Size = new System.Drawing.Size(68, 18);
            this.products_btn_label.TabIndex = 0;
            this.products_btn_label.Text = "Products";
            this.products_btn_label.Click += new System.EventHandler(this.products_btn_label_Click);
            // 
            // dashboard_btn_panel
            // 
            this.dashboard_btn_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dashboard_btn_panel.BackColor = System.Drawing.Color.Honeydew;
            this.dashboard_btn_panel.Controls.Add(this.pictureBox2);
            this.dashboard_btn_panel.Controls.Add(this.dashboard_btn_label);
            this.dashboard_btn_panel.Location = new System.Drawing.Point(0, 98);
            this.dashboard_btn_panel.Name = "dashboard_btn_panel";
            this.dashboard_btn_panel.Size = new System.Drawing.Size(227, 46);
            this.dashboard_btn_panel.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::dispensary_management_system.Properties.Resources.dashboard_line_dark;
            this.pictureBox2.Location = new System.Drawing.Point(19, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // dashboard_btn_label
            // 
            this.dashboard_btn_label.AutoSize = true;
            this.dashboard_btn_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_btn_label.Location = new System.Drawing.Point(132, 14);
            this.dashboard_btn_label.Name = "dashboard_btn_label";
            this.dashboard_btn_label.Size = new System.Drawing.Size(81, 18);
            this.dashboard_btn_label.TabIndex = 0;
            this.dashboard_btn_label.Text = "Dashboard";
            this.dashboard_btn_label.Click += new System.EventHandler(this.dashboard_btn_label_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::dispensary_management_system.Properties.Resources.hospital_line_dark;
            this.pictureBox1.Location = new System.Drawing.Point(22, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dispensary\r\nManagement\r\nSystem";
            // 
            // main_panel
            // 
            this.main_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.main_panel.Location = new System.Drawing.Point(233, 0);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(940, 620);
            this.main_panel.TabIndex = 1;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1173, 620);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.navigation_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin - Dispensary Management System";
            this.navigation_panel.ResumeLayout(false);
            this.navigation_panel.PerformLayout();
            this.treatments_panel.ResumeLayout(false);
            this.treatments_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.logout_btn_panel.ResumeLayout(false);
            this.logout_btn_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.staff_btn_panel.ResumeLayout(false);
            this.staff_btn_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.payments_btn_panel.ResumeLayout(false);
            this.payments_btn_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.products_btn_panel.ResumeLayout(false);
            this.products_btn_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.dashboard_btn_panel.ResumeLayout(false);
            this.dashboard_btn_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navigation_panel;
        private System.Windows.Forms.Panel products_btn_panel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label products_btn_label;
        private System.Windows.Forms.Panel dashboard_btn_panel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label dashboard_btn_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel logout_btn_panel;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label logout_btn_label;
        private System.Windows.Forms.Panel staff_btn_panel;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label staff_btn_label;
        private System.Windows.Forms.Panel payments_btn_panel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label payments_btn_label;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Panel treatments_panel;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label treatments_label;
    }
}