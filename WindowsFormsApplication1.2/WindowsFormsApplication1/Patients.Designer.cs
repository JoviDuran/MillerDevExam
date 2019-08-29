namespace FuaClinic
{
    partial class Patients
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
            this.dataGridPatients = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtECLastName = new System.Windows.Forms.TextBox();
            this.txtECContactNumber = new System.Windows.Forms.TextBox();
            this.txtEcFirstname = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
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
            this.txtFistName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSearchText = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSaveAddress = new System.Windows.Forms.Button();
            this.btnSaveEmergencyContact = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.patientIdForAddress = new System.Windows.Forms.Label();
            this.txtPatientIdAddress = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPatientIdEmergencyContact = new System.Windows.Forms.TextBox();
            this.btnDeleteAddress = new System.Windows.Forms.Button();
            this.btnDeleteEmergencyContact = new System.Windows.Forms.Button();
            this.btnClearAddress = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnClearEmergencyContact = new System.Windows.Forms.Button();
            this.txtSearchFirstName = new System.Windows.Forms.TextBox();
            this.txtSearchLastName = new System.Windows.Forms.TextBox();
            this.advanceSearchLastName = new System.Windows.Forms.Label();
            this.advanceSearchFirstName = new System.Windows.Forms.Label();
            this.btnAdvanceSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridPatients
            // 
            this.dataGridPatients.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPatients.Location = new System.Drawing.Point(632, 203);
            this.dataGridPatients.Name = "dataGridPatients";
            this.dataGridPatients.ReadOnly = true;
            this.dataGridPatients.Size = new System.Drawing.Size(327, 279);
            this.dataGridPatients.TabIndex = 2;
            this.dataGridPatients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPatients_CellContentClick);
            this.dataGridPatients.DoubleClick += new System.EventHandler(this.dataGridPatients_DoubleClick);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(23, 203);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 29);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.SavePatient);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(159, 203);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 29);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.DeletePatient);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(22, 379);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(193, 24);
            this.label19.TabIndex = 66;
            this.label19.Text = "Emergency Contact";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(24, 235);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(87, 24);
            this.label18.TabIndex = 65;
            this.label18.Text = "Address";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(19, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 24);
            this.label17.TabIndex = 64;
            this.label17.Text = "Patient";
            // 
            // txtECLastName
            // 
            this.txtECLastName.Location = new System.Drawing.Point(157, 485);
            this.txtECLastName.Name = "txtECLastName";
            this.txtECLastName.Size = new System.Drawing.Size(133, 20);
            this.txtECLastName.TabIndex = 62;
            // 
            // txtECContactNumber
            // 
            this.txtECContactNumber.Location = new System.Drawing.Point(472, 433);
            this.txtECContactNumber.Name = "txtECContactNumber";
            this.txtECContactNumber.Size = new System.Drawing.Size(133, 20);
            this.txtECContactNumber.TabIndex = 61;
            // 
            // txtEcFirstname
            // 
            this.txtEcFirstname.Location = new System.Drawing.Point(157, 459);
            this.txtEcFirstname.Name = "txtEcFirstname";
            this.txtEcFirstname.Size = new System.Drawing.Size(133, 20);
            this.txtEcFirstname.TabIndex = 60;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(312, 430);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 20);
            this.label12.TabIndex = 58;
            this.label12.Text = "Contact Number";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(25, 485);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 20);
            this.label13.TabIndex = 57;
            this.label13.Text = "Last Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(23, 457);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 20);
            this.label14.TabIndex = 56;
            this.label14.Text = "First Name";
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(472, 277);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(133, 20);
            this.txtProvince.TabIndex = 55;
            this.txtProvince.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 54;
            this.label10.Text = "Email";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(472, 306);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(133, 20);
            this.txtPostalCode.TabIndex = 53;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(154, 304);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(133, 20);
            this.txtCity.TabIndex = 52;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(154, 171);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(133, 20);
            this.txtEmail.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(311, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 20);
            this.label9.TabIndex = 50;
            this.label9.Text = "Postal Code";
            // 
            // txtOccupation
            // 
            this.txtOccupation.AcceptsReturn = true;
            this.txtOccupation.Location = new System.Drawing.Point(154, 134);
            this.txtOccupation.Name = "txtOccupation";
            this.txtOccupation.Size = new System.Drawing.Size(133, 20);
            this.txtOccupation.TabIndex = 49;
            this.txtOccupation.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(472, 138);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(133, 20);
            this.txtContactNumber.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(311, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 20);
            this.label8.TabIndex = 47;
            this.label8.Text = "Contact Number";
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Location = new System.Drawing.Point(472, 99);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(133, 20);
            this.txtBirthDate.TabIndex = 46;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(472, 65);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(133, 20);
            this.txtLastName.TabIndex = 45;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(154, 98);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(133, 20);
            this.txtGender.TabIndex = 44;
            // 
            // txtFistName
            // 
            this.txtFistName.Location = new System.Drawing.Point(154, 63);
            this.txtFistName.Name = "txtFistName";
            this.txtFistName.Size = new System.Drawing.Size(133, 20);
            this.txtFistName.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(312, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 42;
            this.label7.Text = "Province";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Occupation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(311, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Birth Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(311, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Last Name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(20, 61);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 20);
            this.label15.TabIndex = 36;
            this.label15.Text = "First Name";
            // 
            // txtSearchText
            // 
            this.txtSearchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchText.Location = new System.Drawing.Point(726, 46);
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Size = new System.Drawing.Size(92, 26);
            this.txtSearchText.TabIndex = 45;
            this.txtSearchText.TextChanged += new System.EventHandler(this.txtSearchText_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Yellow;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.Location = new System.Drawing.Point(301, 203);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(107, 29);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.ClearPatientButton);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Thistle;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(630, 44);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 31);
            this.btnSearch.TabIndex = 67;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.SearchList);
            // 
            // btnSaveAddress
            // 
            this.btnSaveAddress.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSaveAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaveAddress.Location = new System.Drawing.Point(23, 338);
            this.btnSaveAddress.Name = "btnSaveAddress";
            this.btnSaveAddress.Size = new System.Drawing.Size(107, 29);
            this.btnSaveAddress.TabIndex = 3;
            this.btnSaveAddress.Text = "Save";
            this.btnSaveAddress.UseVisualStyleBackColor = false;
            this.btnSaveAddress.Click += new System.EventHandler(this.SaveAddress);
            // 
            // btnSaveEmergencyContact
            // 
            this.btnSaveEmergencyContact.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSaveEmergencyContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEmergencyContact.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaveEmergencyContact.Location = new System.Drawing.Point(23, 529);
            this.btnSaveEmergencyContact.Name = "btnSaveEmergencyContact";
            this.btnSaveEmergencyContact.Size = new System.Drawing.Size(107, 31);
            this.btnSaveEmergencyContact.TabIndex = 3;
            this.btnSaveEmergencyContact.Text = "Save";
            this.btnSaveEmergencyContact.UseVisualStyleBackColor = false;
            this.btnSaveEmergencyContact.Click += new System.EventHandler(this.SaveEmergencyContact);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 50;
            this.label1.Text = "Postal Code";
            // 
            // patientIdForAddress
            // 
            this.patientIdForAddress.AutoSize = true;
            this.patientIdForAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIdForAddress.Location = new System.Drawing.Point(24, 278);
            this.patientIdForAddress.Name = "patientIdForAddress";
            this.patientIdForAddress.Size = new System.Drawing.Size(77, 20);
            this.patientIdForAddress.TabIndex = 41;
            this.patientIdForAddress.Text = "Patient Id";
            // 
            // txtPatientIdAddress
            // 
            this.txtPatientIdAddress.Location = new System.Drawing.Point(154, 278);
            this.txtPatientIdAddress.Name = "txtPatientIdAddress";
            this.txtPatientIdAddress.Size = new System.Drawing.Size(133, 20);
            this.txtPatientIdAddress.TabIndex = 52;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(23, 431);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 20);
            this.label16.TabIndex = 56;
            this.label16.Text = "Patient Id";
            // 
            // txtPatientIdEmergencyContact
            // 
            this.txtPatientIdEmergencyContact.Location = new System.Drawing.Point(157, 433);
            this.txtPatientIdEmergencyContact.Name = "txtPatientIdEmergencyContact";
            this.txtPatientIdEmergencyContact.Size = new System.Drawing.Size(133, 20);
            this.txtPatientIdEmergencyContact.TabIndex = 60;
            // 
            // btnDeleteAddress
            // 
            this.btnDeleteAddress.BackColor = System.Drawing.Color.Red;
            this.btnDeleteAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteAddress.Location = new System.Drawing.Point(162, 338);
            this.btnDeleteAddress.Name = "btnDeleteAddress";
            this.btnDeleteAddress.Size = new System.Drawing.Size(107, 29);
            this.btnDeleteAddress.TabIndex = 4;
            this.btnDeleteAddress.Text = "Delete";
            this.btnDeleteAddress.UseVisualStyleBackColor = false;
            this.btnDeleteAddress.Click += new System.EventHandler(this.DeleteAddress);
            // 
            // btnDeleteEmergencyContact
            // 
            this.btnDeleteEmergencyContact.BackColor = System.Drawing.Color.Red;
            this.btnDeleteEmergencyContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEmergencyContact.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteEmergencyContact.Location = new System.Drawing.Point(159, 531);
            this.btnDeleteEmergencyContact.Name = "btnDeleteEmergencyContact";
            this.btnDeleteEmergencyContact.Size = new System.Drawing.Size(107, 29);
            this.btnDeleteEmergencyContact.TabIndex = 4;
            this.btnDeleteEmergencyContact.Text = "Delete";
            this.btnDeleteEmergencyContact.UseVisualStyleBackColor = false;
            this.btnDeleteEmergencyContact.Click += new System.EventHandler(this.DeleteEmergencyContact);
            // 
            // btnClearAddress
            // 
            this.btnClearAddress.BackColor = System.Drawing.Color.Yellow;
            this.btnClearAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClearAddress.Location = new System.Drawing.Point(301, 338);
            this.btnClearAddress.Name = "btnClearAddress";
            this.btnClearAddress.Size = new System.Drawing.Size(107, 29);
            this.btnClearAddress.TabIndex = 4;
            this.btnClearAddress.Text = "Clear";
            this.btnClearAddress.UseVisualStyleBackColor = false;
            this.btnClearAddress.Click += new System.EventHandler(this.ClearAddressButton);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(136, 881);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 29);
            this.button5.TabIndex = 4;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.DeletePatient);
            // 
            // btnClearEmergencyContact
            // 
            this.btnClearEmergencyContact.BackColor = System.Drawing.Color.Yellow;
            this.btnClearEmergencyContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearEmergencyContact.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClearEmergencyContact.Location = new System.Drawing.Point(301, 529);
            this.btnClearEmergencyContact.Name = "btnClearEmergencyContact";
            this.btnClearEmergencyContact.Size = new System.Drawing.Size(107, 29);
            this.btnClearEmergencyContact.TabIndex = 4;
            this.btnClearEmergencyContact.Text = "Clear";
            this.btnClearEmergencyContact.UseVisualStyleBackColor = false;
            this.btnClearEmergencyContact.Click += new System.EventHandler(this.ClearEmergencyContactButton);
            // 
            // txtSearchFirstName
            // 
            this.txtSearchFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchFirstName.Location = new System.Drawing.Point(726, 121);
            this.txtSearchFirstName.Name = "txtSearchFirstName";
            this.txtSearchFirstName.Size = new System.Drawing.Size(92, 26);
            this.txtSearchFirstName.TabIndex = 68;
            // 
            // txtSearchLastName
            // 
            this.txtSearchLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchLastName.Location = new System.Drawing.Point(726, 163);
            this.txtSearchLastName.Name = "txtSearchLastName";
            this.txtSearchLastName.Size = new System.Drawing.Size(92, 26);
            this.txtSearchLastName.TabIndex = 69;
            // 
            // advanceSearchLastName
            // 
            this.advanceSearchLastName.AutoSize = true;
            this.advanceSearchLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advanceSearchLastName.Location = new System.Drawing.Point(626, 166);
            this.advanceSearchLastName.Name = "advanceSearchLastName";
            this.advanceSearchLastName.Size = new System.Drawing.Size(86, 20);
            this.advanceSearchLastName.TabIndex = 37;
            this.advanceSearchLastName.Text = "Last Name";
            // 
            // advanceSearchFirstName
            // 
            this.advanceSearchFirstName.AutoSize = true;
            this.advanceSearchFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advanceSearchFirstName.Location = new System.Drawing.Point(626, 123);
            this.advanceSearchFirstName.Name = "advanceSearchFirstName";
            this.advanceSearchFirstName.Size = new System.Drawing.Size(86, 20);
            this.advanceSearchFirstName.TabIndex = 36;
            this.advanceSearchFirstName.Text = "First Name";
            this.advanceSearchFirstName.Click += new System.EventHandler(this.label20_Click);
            // 
            // btnAdvanceSearch
            // 
            this.btnAdvanceSearch.BackColor = System.Drawing.Color.Thistle;
            this.btnAdvanceSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvanceSearch.Location = new System.Drawing.Point(630, 81);
            this.btnAdvanceSearch.Name = "btnAdvanceSearch";
            this.btnAdvanceSearch.Size = new System.Drawing.Size(188, 31);
            this.btnAdvanceSearch.TabIndex = 67;
            this.btnAdvanceSearch.Text = "Advance Search";
            this.btnAdvanceSearch.UseVisualStyleBackColor = false;
            this.btnAdvanceSearch.Click += new System.EventHandler(this.AdvanceSearch);
            // 
            // Patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(1015, 816);
            this.Controls.Add(this.txtSearchLastName);
            this.Controls.Add(this.txtSearchFirstName);
            this.Controls.Add(this.btnAdvanceSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtECLastName);
            this.Controls.Add(this.txtECContactNumber);
            this.Controls.Add(this.txtPatientIdEmergencyContact);
            this.Controls.Add(this.txtEcFirstname);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtProvince);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.txtPatientIdAddress);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtOccupation);
            this.Controls.Add(this.txtContactNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBirthDate);
            this.Controls.Add(this.txtSearchText);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtFistName);
            this.Controls.Add(this.patientIdForAddress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.advanceSearchLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.advanceSearchFirstName);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnClearEmergencyContact);
            this.Controls.Add(this.btnClearAddress);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDeleteEmergencyContact);
            this.Controls.Add(this.btnDeleteAddress);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSaveEmergencyContact);
            this.Controls.Add(this.btnSaveAddress);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridPatients);
            this.Name = "Patients";
            this.Text = "Patients";
            this.Load += new System.EventHandler(this.Patients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridPatients;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtECLastName;
        private System.Windows.Forms.TextBox txtECContactNumber;
        private System.Windows.Forms.TextBox txtEcFirstname;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
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
        private System.Windows.Forms.TextBox txtFistName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSearchText;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSaveAddress;
        private System.Windows.Forms.Button btnSaveEmergencyContact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label patientIdForAddress;
        private System.Windows.Forms.TextBox txtPatientIdAddress;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPatientIdEmergencyContact;
        private System.Windows.Forms.Button btnDeleteAddress;
        private System.Windows.Forms.Button btnDeleteEmergencyContact;
        private System.Windows.Forms.Button btnClearAddress;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnClearEmergencyContact;
        private System.Windows.Forms.TextBox txtSearchFirstName;
        private System.Windows.Forms.TextBox txtSearchLastName;
        private System.Windows.Forms.Label advanceSearchLastName;
        private System.Windows.Forms.Label advanceSearchFirstName;
        private System.Windows.Forms.Button btnAdvanceSearch;
    }
}