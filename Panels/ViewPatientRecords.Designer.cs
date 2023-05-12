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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.patient_records.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.patient_records.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.patient_records.DefaultCellStyle = dataGridViewCellStyle2;
            this.patient_records.Location = new System.Drawing.Point(13, 13);
            this.patient_records.MultiSelect = false;
            this.patient_records.Name = "patient_records";
            this.patient_records.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patient_records.Size = new System.Drawing.Size(1124, 495);
            this.patient_records.TabIndex = 0;
            this.patient_records.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patient_records_CellDoubleClick);
            // 
            // ViewPatientRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1149, 520);
            this.Controls.Add(this.patient_records);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewPatientRecords";
            this.Text = "PatientRecords";
            ((System.ComponentModel.ISupportInitialize)(this.patient_records)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView patient_records;
    }
}