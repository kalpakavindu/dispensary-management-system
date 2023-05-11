namespace dispensary_management_system.Panels
{
    partial class ViewPaymentDetails
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
            this.payments = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.payments)).BeginInit();
            this.SuspendLayout();
            // 
            // payments
            // 
            this.payments.AllowUserToAddRows = false;
            this.payments.AllowUserToDeleteRows = false;
            this.payments.AllowUserToResizeRows = false;
            this.payments.BackgroundColor = System.Drawing.SystemColors.Window;
            this.payments.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.payments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payments.Location = new System.Drawing.Point(12, 12);
            this.payments.MultiSelect = false;
            this.payments.Name = "payments";
            this.payments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.payments.Size = new System.Drawing.Size(1125, 505);
            this.payments.TabIndex = 0;
            // 
            // ViewPaymentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1149, 529);
            this.Controls.Add(this.payments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewPaymentDetails";
            this.Text = "ViewPaymentDetails";
            ((System.ComponentModel.ISupportInitialize)(this.payments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView payments;
    }
}