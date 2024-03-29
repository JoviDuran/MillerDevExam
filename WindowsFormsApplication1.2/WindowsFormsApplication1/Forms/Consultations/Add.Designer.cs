﻿namespace WindowsFormsApplication1.Forms.Consultations
{
    partial class Add
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
            this.txtDiagnosis = new System.Windows.Forms.TextBox();
            this.lblDateofDiagnosis = new System.Windows.Forms.Label();
            this.lblIllness = new System.Windows.Forms.Label();
            this.btnSaveConsulltation = new System.Windows.Forms.Button();
            this.dateTimePickerDateOfConsultation = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDiagnosis
            // 
            this.txtDiagnosis.Location = new System.Drawing.Point(133, 37);
            this.txtDiagnosis.Name = "txtDiagnosis";
            this.txtDiagnosis.Size = new System.Drawing.Size(148, 20);
            this.txtDiagnosis.TabIndex = 107;
            // 
            // lblDateofDiagnosis
            // 
            this.lblDateofDiagnosis.AutoSize = true;
            this.lblDateofDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateofDiagnosis.Location = new System.Drawing.Point(22, 65);
            this.lblDateofDiagnosis.Name = "lblDateofDiagnosis";
            this.lblDateofDiagnosis.Size = new System.Drawing.Size(37, 16);
            this.lblDateofDiagnosis.TabIndex = 105;
            this.lblDateofDiagnosis.Text = "Date";
            // 
            // lblIllness
            // 
            this.lblIllness.AutoSize = true;
            this.lblIllness.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIllness.Location = new System.Drawing.Point(22, 35);
            this.lblIllness.Name = "lblIllness";
            this.lblIllness.Size = new System.Drawing.Size(69, 16);
            this.lblIllness.TabIndex = 106;
            this.lblIllness.Text = "Diagnosis";
            // 
            // btnSaveConsulltation
            // 
            this.btnSaveConsulltation.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSaveConsulltation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveConsulltation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaveConsulltation.Location = new System.Drawing.Point(144, 249);
            this.btnSaveConsulltation.Name = "btnSaveConsulltation";
            this.btnSaveConsulltation.Size = new System.Drawing.Size(107, 31);
            this.btnSaveConsulltation.TabIndex = 110;
            this.btnSaveConsulltation.Text = "Save";
            this.btnSaveConsulltation.UseVisualStyleBackColor = false;
            this.btnSaveConsulltation.Click += new System.EventHandler(this.SaveConsultation);
            // 
            // dateTimePickerDateOfConsultation
            // 
            this.dateTimePickerDateOfConsultation.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDateOfConsultation.CustomFormat = "yyyy-MM-dd hh:mm:ss tt";
            this.dateTimePickerDateOfConsultation.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateOfConsultation.Location = new System.Drawing.Point(133, 65);
            this.dateTimePickerDateOfConsultation.Name = "dateTimePickerDateOfConsultation";
            this.dateTimePickerDateOfConsultation.Size = new System.Drawing.Size(148, 20);
            this.dateTimePickerDateOfConsultation.TabIndex = 111;
            this.dateTimePickerDateOfConsultation.Value = new System.DateTime(2019, 7, 25, 9, 33, 18, 0);
            this.dateTimePickerDateOfConsultation.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dateTimePickerDateOfConsultation_KeyUp);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 297);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 20);
            this.textBox1.TabIndex = 112;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDiagnosis);
            this.groupBox1.Controls.Add(this.lblIllness);
            this.groupBox1.Controls.Add(this.dateTimePickerDateOfConsultation);
            this.groupBox1.Controls.Add(this.lblDateofDiagnosis);
            this.groupBox1.Location = new System.Drawing.Point(47, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 135);
            this.groupBox1.TabIndex = 113;
            this.groupBox1.TabStop = false;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(406, 427);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSaveConsulltation);
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Consultation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDiagnosis;
        private System.Windows.Forms.Label lblDateofDiagnosis;
        private System.Windows.Forms.Label lblIllness;
        private System.Windows.Forms.Button btnSaveConsulltation;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfConsultation;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}