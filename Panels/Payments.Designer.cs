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
            ((System.ComponentModel.ISupportInitialize)(this.payments_list)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
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
            this.view_btn.Location = new System.Drawing.Point(750, 568);
            this.view_btn.Name = "view_btn";
            this.view_btn.Size = new System.Drawing.Size(178, 40);
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
            this.payments_list.Location = new System.Drawing.Point(12, 48);
            this.payments_list.MultiSelect = false;
            this.payments_list.Name = "payments_list";
            this.payments_list.ReadOnly = true;
            this.payments_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.payments_list.Size = new System.Drawing.Size(916, 514);
            this.payments_list.TabIndex = 4;
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(940, 620);
            this.Controls.Add(this.payments_list);
            this.Controls.Add(this.view_btn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Payments";
            this.Text = "Payments";
            ((System.ComponentModel.ISupportInitialize)(this.payments_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button view_btn;
        private System.Windows.Forms.DataGridView payments_list;
    }
}