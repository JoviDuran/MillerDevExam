﻿namespace WindowsFormsApplication1.Forms.Appointments
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
            this.label2 = new System.Windows.Forms.Label();
            this.listViewTestResults = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtDoctorsRemarks = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerAppointment = new System.Windows.Forms.DateTimePicker();
            this.lblDateAppointment = new System.Windows.Forms.Label();
            this.listViewAppointments = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddTestResult = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 145;
            this.label2.Text = "Test Results";
            // 
            // listViewTestResults
            // 
            this.listViewTestResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.listViewTestResults.Location = new System.Drawing.Point(14, 18);
            this.listViewTestResults.Name = "listViewTestResults";
            this.listViewTestResults.Size = new System.Drawing.Size(205, 116);
            this.listViewTestResults.TabIndex = 144;
            this.listViewTestResults.UseCompatibleStateImageBehavior = false;
            this.listViewTestResults.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "File";
            this.columnHeader3.Width = 100;
            // 
            // txtDoctorsRemarks
            // 
            this.txtDoctorsRemarks.Location = new System.Drawing.Point(11, 19);
            this.txtDoctorsRemarks.Multiline = true;
            this.txtDoctorsRemarks.Name = "txtDoctorsRemarks";
            this.txtDoctorsRemarks.Size = new System.Drawing.Size(218, 115);
            this.txtDoctorsRemarks.TabIndex = 143;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 142;
            this.label1.Text = "Doctor\'s Remarks";
            // 
            // dateTimePickerAppointment
            // 
            this.dateTimePickerAppointment.CustomFormat = "yyyy-MM-dd hh:mm:ss tt";
            this.dateTimePickerAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAppointment.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAppointment.Location = new System.Drawing.Point(292, 57);
            this.dateTimePickerAppointment.Name = "dateTimePickerAppointment";
            this.dateTimePickerAppointment.Size = new System.Drawing.Size(174, 22);
            this.dateTimePickerAppointment.TabIndex = 141;
            this.dateTimePickerAppointment.Value = new System.DateTime(2019, 9, 1, 0, 0, 0, 0);
            this.dateTimePickerAppointment.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dateTimePickerAppointment_KeyUp);
            // 
            // lblDateAppointment
            // 
            this.lblDateAppointment.AutoSize = true;
            this.lblDateAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateAppointment.Location = new System.Drawing.Point(163, 57);
            this.lblDateAppointment.Name = "lblDateAppointment";
            this.lblDateAppointment.Size = new System.Drawing.Size(123, 16);
            this.lblDateAppointment.TabIndex = 140;
            this.lblDateAppointment.Text = "Desired Date/Time";
            // 
            // listViewAppointments
            // 
            this.listViewAppointments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listViewAppointments.FullRowSelect = true;
            this.listViewAppointments.GridLines = true;
            this.listViewAppointments.Location = new System.Drawing.Point(335, 141);
            this.listViewAppointments.Name = "listViewAppointments";
            this.listViewAppointments.Size = new System.Drawing.Size(276, 350);
            this.listViewAppointments.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewAppointments.TabIndex = 146;
            this.listViewAppointments.UseCompatibleStateImageBehavior = false;
            this.listViewAppointments.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date&Time";
            this.columnHeader2.Width = 300;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(343, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 16);
            this.label3.TabIndex = 147;
            this.label3.Text = "All Clinic Appointments";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(207, 536);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 22);
            this.btnSave.TabIndex = 148;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddTestResult
            // 
            this.btnAddTestResult.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddTestResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTestResult.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddTestResult.Location = new System.Drawing.Point(187, 314);
            this.btnAddTestResult.Name = "btnAddTestResult";
            this.btnAddTestResult.Size = new System.Drawing.Size(123, 22);
            this.btnAddTestResult.TabIndex = 149;
            this.btnAddTestResult.Text = "Upload";
            this.btnAddTestResult.UseVisualStyleBackColor = false;
            this.btnAddTestResult.Click += new System.EventHandler(this.btnUploadTestResult_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.txtDoctorsRemarks);
            this.groupBox1.Location = new System.Drawing.Point(83, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 147);
            this.groupBox1.TabIndex = 150;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listViewTestResults);
            this.groupBox2.Location = new System.Drawing.Point(86, 346);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 149);
            this.groupBox2.TabIndex = 151;
            this.groupBox2.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.Location = new System.Drawing.Point(346, 536);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 22);
            this.btnCancel.TabIndex = 152;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 679);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddTestResult);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listViewAppointments);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerAppointment);
            this.Controls.Add(this.lblDateAppointment);
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Appointment";
            this.Load += new System.EventHandler(this.Add_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewTestResults;
        private System.Windows.Forms.TextBox txtDoctorsRemarks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerAppointment;
        private System.Windows.Forms.Label lblDateAppointment;
        private System.Windows.Forms.ListView listViewAppointments;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddTestResult;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancel;
    }
}