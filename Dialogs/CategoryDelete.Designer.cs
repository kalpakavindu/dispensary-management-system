namespace dispensary_management_system.Dialogs
{
    partial class CategoryDelete
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
            this.cato_combo = new System.Windows.Forms.ComboBox();
            this.done_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cato_combo
            // 
            this.cato_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cato_combo.FormattingEnabled = true;
            this.cato_combo.Location = new System.Drawing.Point(13, 128);
            this.cato_combo.Name = "cato_combo";
            this.cato_combo.Size = new System.Drawing.Size(341, 24);
            this.cato_combo.TabIndex = 1;
            // 
            // done_btn
            // 
            this.done_btn.BackColor = System.Drawing.SystemColors.Window;
            this.done_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.done_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.done_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.done_btn.Location = new System.Drawing.Point(188, 168);
            this.done_btn.Name = "done_btn";
            this.done_btn.Size = new System.Drawing.Size(75, 23);
            this.done_btn.TabIndex = 3;
            this.done_btn.Text = "Done";
            this.done_btn.UseVisualStyleBackColor = false;
            this.done_btn.Click += new System.EventHandler(this.done_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.SystemColors.Window;
            this.cancel_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.Location = new System.Drawing.Point(279, 168);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 4;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = false;
            // 
            // message
            // 
            this.message.BackColor = System.Drawing.SystemColors.Window;
            this.message.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.message.Cursor = System.Windows.Forms.Cursors.Default;
            this.message.Location = new System.Drawing.Point(13, 13);
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.ReadOnly = true;
            this.message.Size = new System.Drawing.Size(341, 109);
            this.message.TabIndex = 5;
            // 
            // CategoryDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.cancel_btn;
            this.ClientSize = new System.Drawing.Size(367, 203);
            this.Controls.Add(this.message);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.done_btn);
            this.Controls.Add(this.cato_combo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CategoryDelete";
            this.ShowIcon = false;
            this.Text = "Delete Category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cato_combo;
        private System.Windows.Forms.Button done_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.TextBox message;
    }
}