namespace dispensary_management_system.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>S
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.email_in = new System.Windows.Forms.TextBox();
            this.password_in = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.signin_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.reg_link = new System.Windows.Forms.LinkLabel();
            this.eye_btn = new System.Windows.Forms.PictureBox();
            this.close_btn = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eye_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 450);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(29, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 128);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(25, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 117);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dispensary\r\nManagement\r\nSystem";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(360, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sign In";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(363, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(330, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(363, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Email Address";
            // 
            // email_in
            // 
            this.email_in.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_in.Location = new System.Drawing.Point(366, 188);
            this.email_in.Name = "email_in";
            this.email_in.Size = new System.Drawing.Size(324, 24);
            this.email_in.TabIndex = 4;
            // 
            // password_in
            // 
            this.password_in.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_in.Location = new System.Drawing.Point(366, 257);
            this.password_in.Name = "password_in";
            this.password_in.PasswordChar = '*';
            this.password_in.Size = new System.Drawing.Size(292, 24);
            this.password_in.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(363, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Password";
            // 
            // signin_btn
            // 
            this.signin_btn.BackColor = System.Drawing.Color.LightGreen;
            this.signin_btn.FlatAppearance.BorderSize = 0;
            this.signin_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.signin_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.signin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signin_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin_btn.Location = new System.Drawing.Point(366, 323);
            this.signin_btn.Name = "signin_btn";
            this.signin_btn.Size = new System.Drawing.Size(109, 32);
            this.signin_btn.TabIndex = 7;
            this.signin_btn.Text = "Sign In";
            this.signin_btn.UseVisualStyleBackColor = false;
            this.signin_btn.Click += new System.EventHandler(this.Signin_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(481, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "or";
            // 
            // reg_link
            // 
            this.reg_link.AutoSize = true;
            this.reg_link.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_link.Location = new System.Drawing.Point(506, 331);
            this.reg_link.Name = "reg_link";
            this.reg_link.Size = new System.Drawing.Size(152, 16);
            this.reg_link.TabIndex = 9;
            this.reg_link.TabStop = true;
            this.reg_link.Text = "Register to your Account";
            this.reg_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Reg_link_LinkClicked);
            // 
            // eye_btn
            // 
            this.eye_btn.Image = global::dispensary_management_system.Properties.Resources.eye_line_dark;
            this.eye_btn.Location = new System.Drawing.Point(665, 257);
            this.eye_btn.Name = "eye_btn";
            this.eye_btn.Size = new System.Drawing.Size(25, 24);
            this.eye_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eye_btn.TabIndex = 11;
            this.eye_btn.TabStop = false;
            this.eye_btn.Click += new System.EventHandler(this.Eye_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.Image = global::dispensary_management_system.Properties.Resources.close_line_dark;
            this.close_btn.InitialImage = global::dispensary_management_system.Properties.Resources.close_line_dark;
            this.close_btn.Location = new System.Drawing.Point(756, 13);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(32, 33);
            this.close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_btn.TabIndex = 10;
            this.close_btn.TabStop = false;
            this.close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.eye_btn);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.reg_link);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.signin_btn);
            this.Controls.Add(this.password_in);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.email_in);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login - Dispensary Management System";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eye_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox email_in;
        private System.Windows.Forms.TextBox password_in;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button signin_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel reg_link;
        private System.Windows.Forms.PictureBox close_btn;
        private System.Windows.Forms.PictureBox eye_btn;
    }
}