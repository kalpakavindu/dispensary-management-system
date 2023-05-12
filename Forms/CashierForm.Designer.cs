namespace dispensary_management_system.Forms
{
    partial class CashierForm
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
            this.add_payment_panel = new System.Windows.Forms.Panel();
            this.add_payment_label = new System.Windows.Forms.Label();
            this.main_panel = new System.Windows.Forms.Panel();
            this.payments_panel = new System.Windows.Forms.Panel();
            this.payment_details_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.prof_btn = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.add_payment_panel.SuspendLayout();
            this.payments_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // add_payment_panel
            // 
            this.add_payment_panel.BackColor = System.Drawing.Color.Honeydew;
            this.add_payment_panel.Controls.Add(this.add_payment_label);
            this.add_payment_panel.Location = new System.Drawing.Point(12, 47);
            this.add_payment_panel.Name = "add_payment_panel";
            this.add_payment_panel.Size = new System.Drawing.Size(234, 42);
            this.add_payment_panel.TabIndex = 0;
            this.add_payment_panel.Click += new System.EventHandler(this.add_payment_panel_Click);
            // 
            // add_payment_label
            // 
            this.add_payment_label.AutoSize = true;
            this.add_payment_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_payment_label.Location = new System.Drawing.Point(63, 13);
            this.add_payment_label.Name = "add_payment_label";
            this.add_payment_label.Size = new System.Drawing.Size(103, 18);
            this.add_payment_label.TabIndex = 1;
            this.add_payment_label.Text = "Add Payments";
            this.add_payment_label.Click += new System.EventHandler(this.add_payment_label_Click);
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.Honeydew;
            this.main_panel.Location = new System.Drawing.Point(12, 88);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(1149, 520);
            this.main_panel.TabIndex = 1;
            // 
            // payments_panel
            // 
            this.payments_panel.BackColor = System.Drawing.Color.LightGreen;
            this.payments_panel.Controls.Add(this.payment_details_label);
            this.payments_panel.Location = new System.Drawing.Point(252, 47);
            this.payments_panel.Name = "payments_panel";
            this.payments_panel.Size = new System.Drawing.Size(234, 42);
            this.payments_panel.TabIndex = 1;
            this.payments_panel.Click += new System.EventHandler(this.payments_panel_Click);
            // 
            // payment_details_label
            // 
            this.payment_details_label.AutoSize = true;
            this.payment_details_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment_details_label.Location = new System.Drawing.Point(65, 13);
            this.payment_details_label.Name = "payment_details_label";
            this.payment_details_label.Size = new System.Drawing.Size(115, 18);
            this.payment_details_label.TabIndex = 0;
            this.payment_details_label.Text = "Payment Details";
            this.payment_details_label.Click += new System.EventHandler(this.payment_details_label_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Welcome";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(126, 9);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(72, 25);
            this.name.TabIndex = 3;
            this.name.Text = "Name";
            // 
            // prof_btn
            // 
            this.prof_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.prof_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.prof_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.prof_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prof_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prof_btn.Location = new System.Drawing.Point(1015, 9);
            this.prof_btn.Name = "prof_btn";
            this.prof_btn.Size = new System.Drawing.Size(145, 36);
            this.prof_btn.TabIndex = 4;
            this.prof_btn.Text = "See Profile";
            this.prof_btn.UseVisualStyleBackColor = false;
            this.prof_btn.Click += new System.EventHandler(this.prof_btn_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.Salmon;
            this.logout_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.logout_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Location = new System.Drawing.Point(885, 9);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(103, 36);
            this.logout_btn.TabIndex = 5;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // CashierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1173, 620);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.prof_btn);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.payments_panel);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.add_payment_panel);
            this.Name = "CashierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashier - Dispensary Management System";
            this.add_payment_panel.ResumeLayout(false);
            this.add_payment_panel.PerformLayout();
            this.payments_panel.ResumeLayout(false);
            this.payments_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel add_payment_panel;
        private System.Windows.Forms.Label add_payment_label;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Panel payments_panel;
        private System.Windows.Forms.Label payment_details_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button prof_btn;
        private System.Windows.Forms.Button logout_btn;
    }
}