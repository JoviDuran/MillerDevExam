namespace WindowsFormsApplication1
{
    partial class ReadUpdateDelete
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
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.txtECLastName = new System.Windows.Forms.TextBox();
            this.txtECContactNum = new System.Windows.Forms.TextBox();
            this.txtEcFirstname = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOccupation = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBirthDate = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnDeleteAddress = new System.Windows.Forms.Button();
            this.btnViewConsultations = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSaveAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaveAll.Location = new System.Drawing.Point(35, 488);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(107, 31);
            this.btnSaveAll.TabIndex = 138;
            this.btnSaveAll.Text = "Update";
            this.btnSaveAll.UseVisualStyleBackColor = false;
            this.btnSaveAll.Click += new System.EventHandler(this.btnUpdate);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(31, 309);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(193, 24);
            this.label19.TabIndex = 132;
            this.label19.Text = "Emergency Contact";
            // 
            // txtECLastName
            // 
            this.txtECLastName.Location = new System.Drawing.Point(163, 380);
            this.txtECLastName.Name = "txtECLastName";
            this.txtECLastName.Size = new System.Drawing.Size(133, 20);
            this.txtECLastName.TabIndex = 131;
            // 
            // txtECContactNum
            // 
            this.txtECContactNum.Location = new System.Drawing.Point(481, 350);
            this.txtECContactNum.Name = "txtECContactNum";
            this.txtECContactNum.Size = new System.Drawing.Size(133, 20);
            this.txtECContactNum.TabIndex = 130;
            // 
            // txtEcFirstname
            // 
            this.txtEcFirstname.Location = new System.Drawing.Point(163, 354);
            this.txtEcFirstname.Name = "txtEcFirstname";
            this.txtEcFirstname.Size = new System.Drawing.Size(133, 20);
            this.txtEcFirstname.TabIndex = 129;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(321, 351);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 20);
            this.label12.TabIndex = 128;
            this.label12.Text = "Contact Number";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(31, 380);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 20);
            this.label13.TabIndex = 127;
            this.label13.Text = "Last Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(29, 352);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 20);
            this.label14.TabIndex = 126;
            this.label14.Text = "First Name";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(34, 200);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(87, 24);
            this.label18.TabIndex = 125;
            this.label18.Text = "Address";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(31, 12);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 24);
            this.label17.TabIndex = 124;
            this.label17.Text = "Patient";
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(160, 263);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(133, 20);
            this.txtProvince.TabIndex = 123;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(32, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 122;
            this.label10.Text = "Email";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(481, 232);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(133, 20);
            this.txtPostalCode.TabIndex = 121;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(160, 234);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(133, 20);
            this.txtCity.TabIndex = 120;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(163, 155);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(133, 20);
            this.txtEmail.TabIndex = 119;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(322, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 20);
            this.label9.TabIndex = 118;
            this.label9.Text = "Postal Code";
            // 
            // txtOccupation
            // 
            this.txtOccupation.AcceptsReturn = true;
            this.txtOccupation.Location = new System.Drawing.Point(163, 118);
            this.txtOccupation.Name = "txtOccupation";
            this.txtOccupation.Size = new System.Drawing.Size(133, 20);
            this.txtOccupation.TabIndex = 117;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(481, 122);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(133, 20);
            this.txtContactNumber.TabIndex = 116;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(320, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 20);
            this.label8.TabIndex = 115;
            this.label8.Text = "Contact Number";
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Location = new System.Drawing.Point(481, 83);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(133, 20);
            this.txtBirthDate.TabIndex = 114;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(481, 49);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(133, 20);
            this.txtLastName.TabIndex = 113;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(163, 82);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(133, 20);
            this.txtGender.TabIndex = 112;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(163, 47);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(133, 20);
            this.txtFirstName.TabIndex = 111;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 110;
            this.label7.Text = "Province";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 20);
            this.label6.TabIndex = 109;
            this.label6.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 108;
            this.label5.Text = "Occupation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(320, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 107;
            this.label4.Text = "Birth Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 106;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 105;
            this.label2.Text = "Last Name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(29, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 20);
            this.label15.TabIndex = 104;
            this.label15.Text = "First Name";
            // 
            // btnDeleteAddress
            // 
            this.btnDeleteAddress.BackColor = System.Drawing.Color.Red;
            this.btnDeleteAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteAddress.Location = new System.Drawing.Point(186, 489);
            this.btnDeleteAddress.Name = "btnDeleteAddress";
            this.btnDeleteAddress.Size = new System.Drawing.Size(107, 29);
            this.btnDeleteAddress.TabIndex = 140;
            this.btnDeleteAddress.Text = "Delete";
            this.btnDeleteAddress.UseVisualStyleBackColor = false;
            this.btnDeleteAddress.Click += new System.EventHandler(this.btn_Delete);
            // 
            // btnViewConsultations
            // 
            this.btnViewConsultations.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnViewConsultations.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewConsultations.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnViewConsultations.Location = new System.Drawing.Point(34, 430);
            this.btnViewConsultations.Name = "btnViewConsultations";
            this.btnViewConsultations.Size = new System.Drawing.Size(186, 37);
            this.btnViewConsultations.TabIndex = 141;
            this.btnViewConsultations.Text = "Consultations";
            this.btnViewConsultations.UseVisualStyleBackColor = false;
            this.btnViewConsultations.Click += new System.EventHandler(this.btnViewConsultations_Click);
            // 
            // ReadUpdateDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(673, 611);
            this.Controls.Add(this.btnViewConsultations);
            this.Controls.Add(this.btnDeleteAddress);
            this.Controls.Add(this.btnSaveAll);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtECLastName);
            this.Controls.Add(this.txtECContactNum);
            this.Controls.Add(this.txtEcFirstname);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtProvince);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtOccupation);
            this.Controls.Add(this.txtContactNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBirthDate);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label15);
            this.Name = "ReadUpdateDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Information";
            this.Load += new System.EventHandler(this.ReadUpdateDelete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSaveAll;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtECLastName;
        private System.Windows.Forms.TextBox txtECContactNum;
        private System.Windows.Forms.TextBox txtEcFirstname;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOccupation;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBirthDate;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnDeleteAddress;
        private System.Windows.Forms.Button btnViewConsultations;
    }
}