namespace WindowsFormsApplication1.Forms.Appointments
{
    partial class Read
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Read));
            this.txtFirstNameAppointment = new System.Windows.Forms.TextBox();
            this.lblFirstNameAppointment = new System.Windows.Forms.Label();
            this.txtLastNameAppointment = new System.Windows.Forms.TextBox();
            this.lblLastNameAppointment = new System.Windows.Forms.Label();
            this.lblDateAppointment = new System.Windows.Forms.Label();
            this.dateTimePickerAppointment = new System.Windows.Forms.DateTimePicker();
            this.btnCancelAppointment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDoctorsRemarks = new System.Windows.Forms.TextBox();
            this.btnUpdateAppointment = new System.Windows.Forms.Button();
            this.listViewDateTime = new System.Windows.Forms.ListView();
            this.ch3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listViewTestResults = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemoveTestResult = new System.Windows.Forms.Button();
            this.btnAddTestResult = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFirstNameAppointment
            // 
            this.txtFirstNameAppointment.Location = new System.Drawing.Point(162, 42);
            this.txtFirstNameAppointment.Name = "txtFirstNameAppointment";
            this.txtFirstNameAppointment.ReadOnly = true;
            this.txtFirstNameAppointment.Size = new System.Drawing.Size(158, 20);
            this.txtFirstNameAppointment.TabIndex = 109;
            // 
            // lblFirstNameAppointment
            // 
            this.lblFirstNameAppointment.AutoSize = true;
            this.lblFirstNameAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNameAppointment.Location = new System.Drawing.Point(34, 46);
            this.lblFirstNameAppointment.Name = "lblFirstNameAppointment";
            this.lblFirstNameAppointment.Size = new System.Drawing.Size(73, 16);
            this.lblFirstNameAppointment.TabIndex = 108;
            this.lblFirstNameAppointment.Text = "First Name";
            // 
            // txtLastNameAppointment
            // 
            this.txtLastNameAppointment.Location = new System.Drawing.Point(162, 72);
            this.txtLastNameAppointment.Name = "txtLastNameAppointment";
            this.txtLastNameAppointment.ReadOnly = true;
            this.txtLastNameAppointment.Size = new System.Drawing.Size(158, 20);
            this.txtLastNameAppointment.TabIndex = 111;
            // 
            // lblLastNameAppointment
            // 
            this.lblLastNameAppointment.AutoSize = true;
            this.lblLastNameAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastNameAppointment.Location = new System.Drawing.Point(35, 70);
            this.lblLastNameAppointment.Name = "lblLastNameAppointment";
            this.lblLastNameAppointment.Size = new System.Drawing.Size(73, 16);
            this.lblLastNameAppointment.TabIndex = 110;
            this.lblLastNameAppointment.Text = "Last Name";
            // 
            // lblDateAppointment
            // 
            this.lblDateAppointment.AutoSize = true;
            this.lblDateAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateAppointment.Location = new System.Drawing.Point(35, 96);
            this.lblDateAppointment.Name = "lblDateAppointment";
            this.lblDateAppointment.Size = new System.Drawing.Size(123, 16);
            this.lblDateAppointment.TabIndex = 112;
            this.lblDateAppointment.Text = "Desired Date/Time";
            // 
            // dateTimePickerAppointment
            // 
            this.dateTimePickerAppointment.CustomFormat = "yyyy-MM-dd hh:mm:ss tt";
            this.dateTimePickerAppointment.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAppointment.Location = new System.Drawing.Point(162, 98);
            this.dateTimePickerAppointment.Name = "dateTimePickerAppointment";
            this.dateTimePickerAppointment.Size = new System.Drawing.Size(159, 20);
            this.dateTimePickerAppointment.TabIndex = 117;
            this.dateTimePickerAppointment.Value = new System.DateTime(2019, 9, 1, 0, 0, 0, 0);
            this.dateTimePickerAppointment.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dateTimePickerAppointment_KeyUp);
            // 
            // btnCancelAppointment
            // 
            this.btnCancelAppointment.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAppointment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelAppointment.Location = new System.Drawing.Point(472, 615);
            this.btnCancelAppointment.Name = "btnCancelAppointment";
            this.btnCancelAppointment.Size = new System.Drawing.Size(149, 22);
            this.btnCancelAppointment.TabIndex = 121;
            this.btnCancelAppointment.Text = "Cancel";
            this.btnCancelAppointment.UseVisualStyleBackColor = false;
            this.btnCancelAppointment.Click += new System.EventHandler(this.btnCancelAppointment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 122;
            this.label1.Text = "Doctor\'s Remarks";
            // 
            // txtDoctorsRemarks
            // 
            this.txtDoctorsRemarks.Location = new System.Drawing.Point(23, 19);
            this.txtDoctorsRemarks.Multiline = true;
            this.txtDoctorsRemarks.Name = "txtDoctorsRemarks";
            this.txtDoctorsRemarks.Size = new System.Drawing.Size(309, 143);
            this.txtDoctorsRemarks.TabIndex = 123;
            // 
            // btnUpdateAppointment
            // 
            this.btnUpdateAppointment.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdateAppointment.Enabled = false;
            this.btnUpdateAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAppointment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdateAppointment.Location = new System.Drawing.Point(294, 615);
            this.btnUpdateAppointment.Name = "btnUpdateAppointment";
            this.btnUpdateAppointment.Size = new System.Drawing.Size(108, 22);
            this.btnUpdateAppointment.TabIndex = 130;
            this.btnUpdateAppointment.Text = "Update";
            this.btnUpdateAppointment.UseVisualStyleBackColor = false;
            this.btnUpdateAppointment.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // listViewDateTime
            // 
            this.listViewDateTime.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch3});
            this.listViewDateTime.FullRowSelect = true;
            this.listViewDateTime.GridLines = true;
            this.listViewDateTime.Location = new System.Drawing.Point(487, 27);
            this.listViewDateTime.Name = "listViewDateTime";
            this.listViewDateTime.Size = new System.Drawing.Size(134, 570);
            this.listViewDateTime.TabIndex = 131;
            this.listViewDateTime.UseCompatibleStateImageBehavior = false;
            this.listViewDateTime.View = System.Windows.Forms.View.Details;
            this.listViewDateTime.SelectedIndexChanged += new System.EventHandler(this.ListViewDateTime_SelectedIndexChanged);
            // 
            // ch3
            // 
            this.ch3.Text = "Date & Time";
            this.ch3.Width = 150;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "lop.jpg");
            this.imageList1.Images.SetKeyName(1, "lop.jpg");
            // 
            // listViewTestResults
            // 
            this.listViewTestResults.Location = new System.Drawing.Point(19, 19);
            this.listViewTestResults.Name = "listViewTestResults";
            this.listViewTestResults.Size = new System.Drawing.Size(307, 151);
            this.listViewTestResults.TabIndex = 138;
            this.listViewTestResults.UseCompatibleStateImageBehavior = false;
            this.listViewTestResults.View = System.Windows.Forms.View.List;
            this.listViewTestResults.SelectedIndexChanged += new System.EventHandler(this.listViewTestResults_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 139;
            this.label2.Text = "Test Results";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRefresh.Location = new System.Drawing.Point(295, 655);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(108, 22);
            this.btnRefresh.TabIndex = 140;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Location = new System.Drawing.Point(88, 615);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 22);
            this.btnAdd.TabIndex = 141;
            this.btnAdd.Text = "New";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnRemoveTestResult
            // 
            this.btnRemoveTestResult.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRemoveTestResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveTestResult.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRemoveTestResult.Location = new System.Drawing.Point(183, 389);
            this.btnRemoveTestResult.Name = "btnRemoveTestResult";
            this.btnRemoveTestResult.Size = new System.Drawing.Size(60, 22);
            this.btnRemoveTestResult.TabIndex = 143;
            this.btnRemoveTestResult.Text = "Remove";
            this.btnRemoveTestResult.UseVisualStyleBackColor = false;
            this.btnRemoveTestResult.Click += new System.EventHandler(this.BtnRemoveTestResult_Click);
            // 
            // btnAddTestResult
            // 
            this.btnAddTestResult.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddTestResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTestResult.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddTestResult.Location = new System.Drawing.Point(249, 389);
            this.btnAddTestResult.Name = "btnAddTestResult";
            this.btnAddTestResult.Size = new System.Drawing.Size(60, 22);
            this.btnAddTestResult.TabIndex = 144;
            this.btnAddTestResult.Text = "Upload";
            this.btnAddTestResult.UseVisualStyleBackColor = false;
            this.btnAddTestResult.Click += new System.EventHandler(this.BtnUploadTestResult_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLastNameAppointment);
            this.groupBox1.Controls.Add(this.lblFirstNameAppointment);
            this.groupBox1.Controls.Add(this.txtFirstNameAppointment);
            this.groupBox1.Controls.Add(this.lblLastNameAppointment);
            this.groupBox1.Controls.Add(this.lblDateAppointment);
            this.groupBox1.Controls.Add(this.dateTimePickerAppointment);
            this.groupBox1.Location = new System.Drawing.Point(82, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 161);
            this.groupBox1.TabIndex = 145;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDoctorsRemarks);
            this.groupBox2.Location = new System.Drawing.Point(82, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 177);
            this.groupBox2.TabIndex = 146;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listViewTestResults);
            this.groupBox3.Location = new System.Drawing.Point(85, 410);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(349, 187);
            this.groupBox3.TabIndex = 147;
            this.groupBox3.TabStop = false;
            // 
            // Read
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(728, 689);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddTestResult);
            this.Controls.Add(this.btnRemoveTestResult);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewDateTime);
            this.Controls.Add(this.btnUpdateAppointment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelAppointment);
            this.Name = "Read";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointments";
            this.Load += new System.EventHandler(this.Add_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstNameAppointment;
        private System.Windows.Forms.Label lblFirstNameAppointment;
        private System.Windows.Forms.TextBox txtLastNameAppointment;
        private System.Windows.Forms.Label lblLastNameAppointment;
        private System.Windows.Forms.Label lblDateAppointment;
        private System.Windows.Forms.DateTimePicker dateTimePickerAppointment;
        private System.Windows.Forms.Button btnCancelAppointment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDoctorsRemarks;
        private System.Windows.Forms.Button btnUpdateAppointment;
        private System.Windows.Forms.ListView listViewDateTime;
        private System.Windows.Forms.ColumnHeader ch3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listViewTestResults;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemoveTestResult;
        private System.Windows.Forms.Button btnAddTestResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}