namespace WindowsFormsApplication1.Forms.Appointments
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add));
            this.txtFirstNameAppointment = new System.Windows.Forms.TextBox();
            this.lblFirstNameAppointment = new System.Windows.Forms.Label();
            this.txtLastNameAppointment = new System.Windows.Forms.TextBox();
            this.lblLastNameAppointment = new System.Windows.Forms.Label();
            this.lblDateAppointment = new System.Windows.Forms.Label();
            this.btnSaveAppointment = new System.Windows.Forms.Button();
            this.dateTimePickerAppointment = new System.Windows.Forms.DateTimePicker();
            this.btnCancelAppointment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDoctorsRemarks = new System.Windows.Forms.TextBox();
            this.btnUpdateAppointment = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ch1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.radioAtDesiredDate = new System.Windows.Forms.RadioButton();
            this.radioAtPatientsAppointment = new System.Windows.Forms.RadioButton();
            this.radioAll = new System.Windows.Forms.RadioButton();
            this.btnTestResults = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // txtFirstNameAppointment
            // 
            this.txtFirstNameAppointment.Location = new System.Drawing.Point(173, 85);
            this.txtFirstNameAppointment.Name = "txtFirstNameAppointment";
            this.txtFirstNameAppointment.ReadOnly = true;
            this.txtFirstNameAppointment.Size = new System.Drawing.Size(158, 20);
            this.txtFirstNameAppointment.TabIndex = 109;
            this.txtFirstNameAppointment.TextChanged += new System.EventHandler(this.txtFirstNameAppointment_TextChanged);
            // 
            // lblFirstNameAppointment
            // 
            this.lblFirstNameAppointment.AutoSize = true;
            this.lblFirstNameAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNameAppointment.Location = new System.Drawing.Point(45, 89);
            this.lblFirstNameAppointment.Name = "lblFirstNameAppointment";
            this.lblFirstNameAppointment.Size = new System.Drawing.Size(73, 16);
            this.lblFirstNameAppointment.TabIndex = 108;
            this.lblFirstNameAppointment.Text = "First Name";
            this.lblFirstNameAppointment.Click += new System.EventHandler(this.lblFirstNameAppointment_Click);
            // 
            // txtLastNameAppointment
            // 
            this.txtLastNameAppointment.Location = new System.Drawing.Point(173, 115);
            this.txtLastNameAppointment.Name = "txtLastNameAppointment";
            this.txtLastNameAppointment.ReadOnly = true;
            this.txtLastNameAppointment.Size = new System.Drawing.Size(158, 20);
            this.txtLastNameAppointment.TabIndex = 111;
            this.txtLastNameAppointment.TextChanged += new System.EventHandler(this.txtLastNameAppointment_TextChanged);
            // 
            // lblLastNameAppointment
            // 
            this.lblLastNameAppointment.AutoSize = true;
            this.lblLastNameAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastNameAppointment.Location = new System.Drawing.Point(46, 113);
            this.lblLastNameAppointment.Name = "lblLastNameAppointment";
            this.lblLastNameAppointment.Size = new System.Drawing.Size(73, 16);
            this.lblLastNameAppointment.TabIndex = 110;
            this.lblLastNameAppointment.Text = "Last Name";
            this.lblLastNameAppointment.Click += new System.EventHandler(this.lblLastNameAppointment_Click);
            // 
            // lblDateAppointment
            // 
            this.lblDateAppointment.AutoSize = true;
            this.lblDateAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateAppointment.Location = new System.Drawing.Point(46, 140);
            this.lblDateAppointment.Name = "lblDateAppointment";
            this.lblDateAppointment.Size = new System.Drawing.Size(123, 16);
            this.lblDateAppointment.TabIndex = 112;
            this.lblDateAppointment.Text = "Desired Date/Time";
            this.lblDateAppointment.Click += new System.EventHandler(this.lblDateAppointment_Click);
            // 
            // btnSaveAppointment
            // 
            this.btnSaveAppointment.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSaveAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAppointment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaveAppointment.Location = new System.Drawing.Point(58, 406);
            this.btnSaveAppointment.Name = "btnSaveAppointment";
            this.btnSaveAppointment.Size = new System.Drawing.Size(111, 31);
            this.btnSaveAppointment.TabIndex = 116;
            this.btnSaveAppointment.Text = "Save";
            this.btnSaveAppointment.UseVisualStyleBackColor = false;
            this.btnSaveAppointment.Click += new System.EventHandler(this.btnSaveAppointment_Click);
            // 
            // dateTimePickerAppointment
            // 
            this.dateTimePickerAppointment.CustomFormat = "yyyy-MM-dd hh:mm:ss tt";
            this.dateTimePickerAppointment.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAppointment.Location = new System.Drawing.Point(173, 141);
            this.dateTimePickerAppointment.Name = "dateTimePickerAppointment";
            this.dateTimePickerAppointment.Size = new System.Drawing.Size(159, 20);
            this.dateTimePickerAppointment.TabIndex = 117;
            this.dateTimePickerAppointment.Value = new System.DateTime(2019, 9, 1, 0, 0, 0, 0);
            this.dateTimePickerAppointment.ValueChanged += new System.EventHandler(this.dateTimePickerAppointment_ValueChanged);
            // 
            // btnCancelAppointment
            // 
            this.btnCancelAppointment.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAppointment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelAppointment.Location = new System.Drawing.Point(175, 406);
            this.btnCancelAppointment.Name = "btnCancelAppointment";
            this.btnCancelAppointment.Size = new System.Drawing.Size(159, 68);
            this.btnCancelAppointment.TabIndex = 121;
            this.btnCancelAppointment.Text = "Cancel Appointment";
            this.btnCancelAppointment.UseVisualStyleBackColor = false;
            this.btnCancelAppointment.Click += new System.EventHandler(this.btnCancelAppointment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 122;
            this.label1.Text = "Doctor\'s Remarks";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDoctorsRemarks
            // 
            this.txtDoctorsRemarks.Location = new System.Drawing.Point(48, 246);
            this.txtDoctorsRemarks.Multiline = true;
            this.txtDoctorsRemarks.Name = "txtDoctorsRemarks";
            this.txtDoctorsRemarks.Size = new System.Drawing.Size(286, 124);
            this.txtDoctorsRemarks.TabIndex = 123;
            this.txtDoctorsRemarks.TextChanged += new System.EventHandler(this.txtDoctorsRemarks_TextChanged);
            // 
            // btnUpdateAppointment
            // 
            this.btnUpdateAppointment.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdateAppointment.Enabled = false;
            this.btnUpdateAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAppointment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdateAppointment.Location = new System.Drawing.Point(58, 443);
            this.btnUpdateAppointment.Name = "btnUpdateAppointment";
            this.btnUpdateAppointment.Size = new System.Drawing.Size(108, 31);
            this.btnUpdateAppointment.TabIndex = 130;
            this.btnUpdateAppointment.Text = "Update";
            this.btnUpdateAppointment.UseVisualStyleBackColor = false;
            this.btnUpdateAppointment.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch1,
            this.ch2,
            this.ch3});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(388, 104);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(457, 219);
            this.listView1.TabIndex = 131;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // ch1
            // 
            this.ch1.Text = "FirstName";
            this.ch1.Width = 150;
            // 
            // ch2
            // 
            this.ch2.Text = "LastName";
            this.ch2.Width = 150;
            // 
            // ch3
            // 
            this.ch3.Text = "DesiredDateTime";
            this.ch3.Width = 150;
            // 
            // radioAtDesiredDate
            // 
            this.radioAtDesiredDate.AutoSize = true;
            this.radioAtDesiredDate.Location = new System.Drawing.Point(388, 81);
            this.radioAtDesiredDate.Name = "radioAtDesiredDate";
            this.radioAtDesiredDate.Size = new System.Drawing.Size(100, 17);
            this.radioAtDesiredDate.TabIndex = 133;
            this.radioAtDesiredDate.TabStop = true;
            this.radioAtDesiredDate.Text = "At Desired Date";
            this.radioAtDesiredDate.UseVisualStyleBackColor = true;
            this.radioAtDesiredDate.CheckedChanged += new System.EventHandler(this.RadioAtDesiredDate_CheckedChanged);
            // 
            // radioAtPatientsAppointment
            // 
            this.radioAtPatientsAppointment.AutoSize = true;
            this.radioAtPatientsAppointment.Location = new System.Drawing.Point(528, 81);
            this.radioAtPatientsAppointment.Name = "radioAtPatientsAppointment";
            this.radioAtPatientsAppointment.Size = new System.Drawing.Size(132, 17);
            this.radioAtPatientsAppointment.TabIndex = 134;
            this.radioAtPatientsAppointment.TabStop = true;
            this.radioAtPatientsAppointment.Text = "Patient\'s Appointments";
            this.radioAtPatientsAppointment.UseVisualStyleBackColor = true;
            this.radioAtPatientsAppointment.CheckedChanged += new System.EventHandler(this.RadioAtPatientsAppointment_CheckedChanged);
            // 
            // radioAll
            // 
            this.radioAll.AutoSize = true;
            this.radioAll.Location = new System.Drawing.Point(684, 81);
            this.radioAll.Name = "radioAll";
            this.radioAll.Size = new System.Drawing.Size(36, 17);
            this.radioAll.TabIndex = 135;
            this.radioAll.TabStop = true;
            this.radioAll.Text = "All";
            this.radioAll.UseVisualStyleBackColor = true;
            this.radioAll.CheckedChanged += new System.EventHandler(this.RadioAll_CheckedChanged);
            // 
            // btnTestResults
            // 
            this.btnTestResults.Location = new System.Drawing.Point(175, 178);
            this.btnTestResults.Name = "btnTestResults";
            this.btnTestResults.Size = new System.Drawing.Size(156, 23);
            this.btnTestResults.TabIndex = 136;
            this.btnTestResults.Text = "Test Results";
            this.btnTestResults.UseVisualStyleBackColor = true;
            this.btnTestResults.Click += new System.EventHandler(this.BtnTestResults_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "lop.jpg");
            this.imageList1.Images.SetKeyName(1, "lop.jpg");
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(919, 633);
            this.Controls.Add(this.btnTestResults);
            this.Controls.Add(this.radioAll);
            this.Controls.Add(this.radioAtPatientsAppointment);
            this.Controls.Add(this.radioAtDesiredDate);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnUpdateAppointment);
            this.Controls.Add(this.txtDoctorsRemarks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelAppointment);
            this.Controls.Add(this.dateTimePickerAppointment);
            this.Controls.Add(this.btnSaveAppointment);
            this.Controls.Add(this.lblDateAppointment);
            this.Controls.Add(this.txtLastNameAppointment);
            this.Controls.Add(this.lblLastNameAppointment);
            this.Controls.Add(this.txtFirstNameAppointment);
            this.Controls.Add(this.lblFirstNameAppointment);
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Appointment";
            this.Load += new System.EventHandler(this.Add_Load);
            this.Click += new System.EventHandler(this.Add_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstNameAppointment;
        private System.Windows.Forms.Label lblFirstNameAppointment;
        private System.Windows.Forms.TextBox txtLastNameAppointment;
        private System.Windows.Forms.Label lblLastNameAppointment;
        private System.Windows.Forms.Label lblDateAppointment;
        private System.Windows.Forms.Button btnSaveAppointment;
        private System.Windows.Forms.DateTimePicker dateTimePickerAppointment;
        private System.Windows.Forms.Button btnCancelAppointment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDoctorsRemarks;
        private System.Windows.Forms.Button btnUpdateAppointment;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ch1;
        private System.Windows.Forms.ColumnHeader ch2;
        private System.Windows.Forms.ColumnHeader ch3;
        private System.Windows.Forms.RadioButton radioAtDesiredDate;
        private System.Windows.Forms.RadioButton radioAtPatientsAppointment;
        private System.Windows.Forms.RadioButton radioAll;
        private System.Windows.Forms.Button btnTestResults;
        private System.Windows.Forms.ImageList imageList1;
    }
}