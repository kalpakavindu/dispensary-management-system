namespace dispensary_management_system.Forms
{
    partial class PatientForm
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
            this.prof_btn = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.treatments_panel = new System.Windows.Forms.Panel();
            this.treatment_details_label = new System.Windows.Forms.Label();
            this.main_panel = new System.Windows.Forms.Panel();
            this.add_treatment_panel = new System.Windows.Forms.Panel();
            this.add_treatment_label = new System.Windows.Forms.Label();
            this.treatments_panel.SuspendLayout();
            this.add_treatment_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // prof_btn
            // 
            this.prof_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.prof_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.prof_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.prof_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prof_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prof_btn.Location = new System.Drawing.Point(1015, 11);
            this.prof_btn.Name = "prof_btn";
            this.prof_btn.Size = new System.Drawing.Size(145, 36);
            this.prof_btn.TabIndex = 10;
            this.prof_btn.Text = "See Profile";
            this.prof_btn.UseVisualStyleBackColor = false;
            this.prof_btn.Click += new System.EventHandler(this.prof_btn_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(126, 11);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(72, 25);
            this.name.TabIndex = 9;
            this.name.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Welcome";
            // 
            // treatments_panel
            // 
            this.treatments_panel.BackColor = System.Drawing.Color.LightGreen;
            this.treatments_panel.Controls.Add(this.treatment_details_label);
            this.treatments_panel.Location = new System.Drawing.Point(252, 49);
            this.treatments_panel.Name = "treatments_panel";
            this.treatments_panel.Size = new System.Drawing.Size(234, 42);
            this.treatments_panel.TabIndex = 6;
            this.treatments_panel.Click += new System.EventHandler(this.treatments_panel_Click);
            // 
            // treatment_details_label
            // 
            this.treatment_details_label.AutoSize = true;
            this.treatment_details_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treatment_details_label.Location = new System.Drawing.Point(65, 13);
            this.treatment_details_label.Name = "treatment_details_label";
            this.treatment_details_label.Size = new System.Drawing.Size(114, 18);
            this.treatment_details_label.TabIndex = 0;
            this.treatment_details_label.Text = "Patient Records";
            this.treatment_details_label.Click += new System.EventHandler(this.treatment_details_label_Click);
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.Honeydew;
            this.main_panel.Location = new System.Drawing.Point(12, 90);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(1149, 520);
            this.main_panel.TabIndex = 7;
            // 
            // add_treatment_panel
            // 
            this.add_treatment_panel.BackColor = System.Drawing.Color.Honeydew;
            this.add_treatment_panel.Controls.Add(this.add_treatment_label);
            this.add_treatment_panel.Location = new System.Drawing.Point(12, 49);
            this.add_treatment_panel.Name = "add_treatment_panel";
            this.add_treatment_panel.Size = new System.Drawing.Size(234, 42);
            this.add_treatment_panel.TabIndex = 5;
            this.add_treatment_panel.Click += new System.EventHandler(this.add_treatment_panel_Click);
            // 
            // add_treatment_label
            // 
            this.add_treatment_label.AutoSize = true;
            this.add_treatment_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_treatment_label.Location = new System.Drawing.Point(63, 13);
            this.add_treatment_label.Name = "add_treatment_label";
            this.add_treatment_label.Size = new System.Drawing.Size(82, 18);
            this.add_treatment_label.TabIndex = 1;
            this.add_treatment_label.Text = "Add Patient";
            this.add_treatment_label.Click += new System.EventHandler(this.add_treatment_label_Click);
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1173, 620);
            this.Controls.Add(this.prof_btn);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.treatments_panel);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.add_treatment_panel);
            this.Name = "PatientForm";
            this.Text = "Treatments - Dispensary Management System";
            this.treatments_panel.ResumeLayout(false);
            this.treatments_panel.PerformLayout();
            this.add_treatment_panel.ResumeLayout(false);
            this.add_treatment_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prof_btn;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel treatments_panel;
        private System.Windows.Forms.Label treatment_details_label;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Panel add_treatment_panel;
        private System.Windows.Forms.Label add_treatment_label;
    }
}