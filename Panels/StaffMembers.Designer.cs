namespace dispensary_management_system.Panels
{
    partial class StaffMembers
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
            this.member_list = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.member_list)).BeginInit();
            this.SuspendLayout();
            // 
            // member_list
            // 
            this.member_list.AllowUserToAddRows = false;
            this.member_list.AllowUserToDeleteRows = false;
            this.member_list.AllowUserToResizeRows = false;
            this.member_list.BackgroundColor = System.Drawing.SystemColors.Window;
            this.member_list.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.member_list.Enabled = false;
            this.member_list.Location = new System.Drawing.Point(12, 46);
            this.member_list.MultiSelect = false;
            this.member_list.Name = "member_list";
            this.member_list.ReadOnly = true;
            this.member_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.member_list.Size = new System.Drawing.Size(916, 514);
            this.member_list.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Manage Staff";
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.LightGreen;
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.add_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(750, 568);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(178, 40);
            this.add_btn.TabIndex = 4;
            this.add_btn.Text = "Add New Member";
            this.add_btn.UseVisualStyleBackColor = false;
            // 
            // StaffMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(940, 620);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.member_list);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffMembers";
            this.Text = "StaffMembers";
            ((System.ComponentModel.ISupportInitialize)(this.member_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView member_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add_btn;
    }
}