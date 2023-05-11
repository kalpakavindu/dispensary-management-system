namespace dispensary_management_system.Panels
{
    partial class ViewPatientRecords
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
            this.patient_records = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.patient_records)).BeginInit();
            this.SuspendLayout();
            // 
            // patient_records
            // 
            this.patient_records.AllowUserToAddRows = false;
            this.patient_records.AllowUserToDeleteRows = false;
            this.patient_records.AllowUserToOrderColumns = true;
            this.patient_records.AllowUserToResizeRows = false;
            this.patient_records.BackgroundColor = System.Drawing.SystemColors.Window;
            this.patient_records.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.patient_records.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patient_records.Location = new System.Drawing.Point(13, 13);
            this.patient_records.MultiSelect = false;
            this.patient_records.Name = "patient_records";
            this.patient_records.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patient_records.Size = new System.Drawing.Size(1124, 495);
            this.patient_records.TabIndex = 0;
            // 
            // PatientRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1149, 520);
            this.Controls.Add(this.patient_records);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatientRecords";
            this.Text = "PatientRecords";
            ((System.ComponentModel.ISupportInitialize)(this.patient_records)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView patient_records;
    }
}