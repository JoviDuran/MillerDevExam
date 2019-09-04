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
            this.label2 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.txtDoctorsRemarks = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerAppointment = new System.Windows.Forms.DateTimePicker();
            this.lblDateAppointment = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddTestResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 440);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 145;
            this.label2.Text = "Test Results";
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(187, 480);
            this.listView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(336, 266);
            this.listView2.TabIndex = 144;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // txtDoctorsRemarks
            // 
            this.txtDoctorsRemarks.Location = new System.Drawing.Point(187, 209);
            this.txtDoctorsRemarks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDoctorsRemarks.Multiline = true;
            this.txtDoctorsRemarks.Name = "txtDoctorsRemarks";
            this.txtDoctorsRemarks.Size = new System.Drawing.Size(336, 189);
            this.txtDoctorsRemarks.TabIndex = 143;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 177);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.dateTimePickerAppointment.Location = new System.Drawing.Point(486, 88);
            this.dateTimePickerAppointment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerAppointment.Name = "dateTimePickerAppointment";
            this.dateTimePickerAppointment.Size = new System.Drawing.Size(236, 22);
            this.dateTimePickerAppointment.TabIndex = 141;
            this.dateTimePickerAppointment.Value = new System.DateTime(2019, 9, 1, 0, 0, 0, 0);
            // 
            // lblDateAppointment
            // 
            this.lblDateAppointment.AutoSize = true;
            this.lblDateAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateAppointment.Location = new System.Drawing.Point(292, 88);
            this.lblDateAppointment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateAppointment.Name = "lblDateAppointment";
            this.lblDateAppointment.Size = new System.Drawing.Size(123, 16);
            this.lblDateAppointment.TabIndex = 140;
            this.lblDateAppointment.Text = "Desired Date/Time";
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(550, 209);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(343, 536);
            this.listView1.TabIndex = 146;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(562, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 16);
            this.label3.TabIndex = 147;
            this.label3.Text = "All Clinic Appointments";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Location = new System.Drawing.Point(464, 857);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(184, 34);
            this.btnAdd.TabIndex = 148;
            this.btnAdd.Text = "Save";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnAddTestResult
            // 
            this.btnAddTestResult.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddTestResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTestResult.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddTestResult.Location = new System.Drawing.Point(333, 440);
            this.btnAddTestResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddTestResult.Name = "btnAddTestResult";
            this.btnAddTestResult.Size = new System.Drawing.Size(184, 34);
            this.btnAddTestResult.TabIndex = 149;
            this.btnAddTestResult.Text = "Add";
            this.btnAddTestResult.UseVisualStyleBackColor = false;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 1045);
            this.Controls.Add(this.btnAddTestResult);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.txtDoctorsRemarks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerAppointment);
            this.Controls.Add(this.lblDateAppointment);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.TextBox txtDoctorsRemarks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerAppointment;
        private System.Windows.Forms.Label lblDateAppointment;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddTestResult;
    }
}