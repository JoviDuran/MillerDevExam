namespace FuaClinic
{
    partial class Home
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.dataGridViewPatients = new System.Windows.Forms.DataGridView();
            this.txtSearchLastName = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPatients = new System.Windows.Forms.TabPage();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.btnDeletePatient = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textSearchFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabConsultations = new System.Windows.Forms.TabPage();
            this.btnViewConsultations = new System.Windows.Forms.Button();
            this.dateOfConsultationPicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewConsultations = new System.Windows.Forms.DataGridView();
            this.AppointmentsTab = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerAppointment = new System.Windows.Forms.DateTimePicker();
            this.btnRefreshDataGridViewAppointments = new System.Windows.Forms.Button();
            this.btnDeleteAppointment = new System.Windows.Forms.Button();
            this.dataGridViewAppointments = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRefreshPatientArchive = new System.Windows.Forms.Button();
            this.btnSearchPatientArchive = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearchFirstNamePA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSearchLastNamePA = new System.Windows.Forms.TextBox();
            this.dataGridViewPArchive = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPatients.SuspendLayout();
            this.tabConsultations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultations)).BeginInit();
            this.AppointmentsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPArchive)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddPatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPatient.Location = new System.Drawing.Point(140, 601);
            this.btnAddPatient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(114, 29);
            this.btnAddPatient.TabIndex = 7;
            this.btnAddPatient.Text = "Add ";
            this.btnAddPatient.UseVisualStyleBackColor = false;
            this.btnAddPatient.Click += new System.EventHandler(this.AddPatient_Click);
            // 
            // dataGridViewPatients
            // 
            this.dataGridViewPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewPatients.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPatients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPatients.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPatients.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewPatients.Location = new System.Drawing.Point(133, 255);
            this.dataGridViewPatients.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewPatients.Name = "dataGridViewPatients";
            this.dataGridViewPatients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPatients.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPatients.RowHeadersVisible = false;
            this.dataGridViewPatients.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPatients.Size = new System.Drawing.Size(417, 312);
            this.dataGridViewPatients.TabIndex = 8;
            this.dataGridViewPatients.DoubleClick += new System.EventHandler(this.ViewPatientInfo_Click);
            // 
            // txtSearchLastName
            // 
            this.txtSearchLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchLastName.Location = new System.Drawing.Point(443, 102);
            this.txtSearchLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchLastName.Name = "txtSearchLastName";
            this.txtSearchLastName.Size = new System.Drawing.Size(108, 22);
            this.txtSearchLastName.TabIndex = 69;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPatients);
            this.tabControl1.Controls.Add(this.tabConsultations);
            this.tabControl1.Controls.Add(this.AppointmentsTab);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(63, 79);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(736, 742);
            this.tabControl1.TabIndex = 75;
            // 
            // tabPatients
            // 
            this.tabPatients.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPatients.Controls.Add(this.radioFemale);
            this.tabPatients.Controls.Add(this.radioMale);
            this.tabPatients.Controls.Add(this.btnDeletePatient);
            this.tabPatients.Controls.Add(this.button2);
            this.tabPatients.Controls.Add(this.button1);
            this.tabPatients.Controls.Add(this.label4);
            this.tabPatients.Controls.Add(this.label3);
            this.tabPatients.Controls.Add(this.textSearchFirstName);
            this.tabPatients.Controls.Add(this.label2);
            this.tabPatients.Controls.Add(this.dataGridViewPatients);
            this.tabPatients.Controls.Add(this.txtSearchLastName);
            this.tabPatients.Controls.Add(this.btnAddPatient);
            this.tabPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPatients.Location = new System.Drawing.Point(4, 24);
            this.tabPatients.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPatients.Name = "tabPatients";
            this.tabPatients.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPatients.Size = new System.Drawing.Size(728, 714);
            this.tabPatients.TabIndex = 0;
            this.tabPatients.Text = "Patients";
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(262, 142);
            this.radioFemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(31, 17);
            this.radioFemale.TabIndex = 83;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "F";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Location = new System.Drawing.Point(222, 142);
            this.radioMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(34, 17);
            this.radioMale.TabIndex = 82;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "M";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // btnDeletePatient
            // 
            this.btnDeletePatient.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeletePatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeletePatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePatient.Location = new System.Drawing.Point(262, 601);
            this.btnDeletePatient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeletePatient.Name = "btnDeletePatient";
            this.btnDeletePatient.Size = new System.Drawing.Size(114, 29);
            this.btnDeletePatient.TabIndex = 81;
            this.btnDeletePatient.Text = "Delete";
            this.btnDeletePatient.UseVisualStyleBackColor = false;
            this.btnDeletePatient.Click += new System.EventHandler(this.DeletePatient_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(133, 216);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 29);
            this.button2.TabIndex = 80;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.RefreshDataGridViewPatients_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(136, 58);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 29);
            this.button1.TabIndex = 79;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.SearchPatient_Click);
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 78;
            this.label4.Text = "Gender:";
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 76;
            this.label3.Text = "First Name:";
            // 
            // textSearchFirstName
            // 
            this.textSearchFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearchFirstName.Location = new System.Drawing.Point(218, 105);
            this.textSearchFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textSearchFirstName.Name = "textSearchFirstName";
            this.textSearchFirstName.Size = new System.Drawing.Size(109, 22);
            this.textSearchFirstName.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 74;
            this.label2.Text = "Last Name:";
            // 
            // tabConsultations
            // 
            this.tabConsultations.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabConsultations.Controls.Add(this.btnViewConsultations);
            this.tabConsultations.Controls.Add(this.dateOfConsultationPicker);
            this.tabConsultations.Controls.Add(this.label6);
            this.tabConsultations.Controls.Add(this.dataGridViewConsultations);
            this.tabConsultations.Location = new System.Drawing.Point(4, 24);
            this.tabConsultations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabConsultations.Name = "tabConsultations";
            this.tabConsultations.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabConsultations.Size = new System.Drawing.Size(728, 714);
            this.tabConsultations.TabIndex = 1;
            this.tabConsultations.Text = "Consultations";
            // 
            // btnViewConsultations
            // 
            this.btnViewConsultations.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnViewConsultations.Location = new System.Drawing.Point(187, 558);
            this.btnViewConsultations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewConsultations.Name = "btnViewConsultations";
            this.btnViewConsultations.Size = new System.Drawing.Size(123, 28);
            this.btnViewConsultations.TabIndex = 80;
            this.btnViewConsultations.Text = "Refresh";
            this.btnViewConsultations.UseVisualStyleBackColor = false;
            this.btnViewConsultations.Click += new System.EventHandler(this.RefreshDataGridViewConsultations_Click);
            // 
            // dateOfConsultationPicker
            // 
            this.dateOfConsultationPicker.CustomFormat = "yyyy-MM-dd";
            this.dateOfConsultationPicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateOfConsultationPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOfConsultationPicker.Location = new System.Drawing.Point(328, 85);
            this.dateOfConsultationPicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateOfConsultationPicker.Name = "dateOfConsultationPicker";
            this.dateOfConsultationPicker.Size = new System.Drawing.Size(157, 21);
            this.dateOfConsultationPicker.TabIndex = 79;
            this.dateOfConsultationPicker.ValueChanged += new System.EventHandler(this.dateOfConsultationPicker_ValueChanged);
            this.dateOfConsultationPicker.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dateTimePickerConsultations_keyUp);
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(184, 86);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 78;
            this.label6.Text = "Date:";
            // 
            // dataGridViewConsultations
            // 
            this.dataGridViewConsultations.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewConsultations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewConsultations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewConsultations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewConsultations.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewConsultations.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewConsultations.Location = new System.Drawing.Point(187, 116);
            this.dataGridViewConsultations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewConsultations.Name = "dataGridViewConsultations";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewConsultations.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewConsultations.RowHeadersVisible = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewConsultations.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewConsultations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewConsultations.Size = new System.Drawing.Size(298, 431);
            this.dataGridViewConsultations.TabIndex = 71;
            this.dataGridViewConsultations.DoubleClick += new System.EventHandler(this.ViewPatientInfoThroughConsultation_Click);
            // 
            // AppointmentsTab
            // 
            this.AppointmentsTab.Controls.Add(this.label5);
            this.AppointmentsTab.Controls.Add(this.dateTimePickerAppointment);
            this.AppointmentsTab.Controls.Add(this.btnRefreshDataGridViewAppointments);
            this.AppointmentsTab.Controls.Add(this.btnDeleteAppointment);
            this.AppointmentsTab.Controls.Add(this.dataGridViewAppointments);
            this.AppointmentsTab.Location = new System.Drawing.Point(4, 24);
            this.AppointmentsTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AppointmentsTab.Name = "AppointmentsTab";
            this.AppointmentsTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AppointmentsTab.Size = new System.Drawing.Size(728, 714);
            this.AppointmentsTab.TabIndex = 2;
            this.AppointmentsTab.Text = "Appointments";
            this.AppointmentsTab.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 112);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 83;
            this.label5.Text = "Date:";
            // 
            // dateTimePickerAppointment
            // 
            this.dateTimePickerAppointment.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerAppointment.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePickerAppointment.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAppointment.Location = new System.Drawing.Point(148, 108);
            this.dateTimePickerAppointment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerAppointment.Name = "dateTimePickerAppointment";
            this.dateTimePickerAppointment.Size = new System.Drawing.Size(164, 21);
            this.dateTimePickerAppointment.TabIndex = 82;
            this.dateTimePickerAppointment.ValueChanged += new System.EventHandler(this.dateTimePickerAppointment_ValueChanged);
            this.dateTimePickerAppointment.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dateTimePickerAppointment_KeyUp);
            // 
            // btnRefreshDataGridViewAppointments
            // 
            this.btnRefreshDataGridViewAppointments.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRefreshDataGridViewAppointments.Location = new System.Drawing.Point(249, 598);
            this.btnRefreshDataGridViewAppointments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefreshDataGridViewAppointments.Name = "btnRefreshDataGridViewAppointments";
            this.btnRefreshDataGridViewAppointments.Size = new System.Drawing.Size(141, 36);
            this.btnRefreshDataGridViewAppointments.TabIndex = 81;
            this.btnRefreshDataGridViewAppointments.Text = "Refresh";
            this.btnRefreshDataGridViewAppointments.UseVisualStyleBackColor = false;
            this.btnRefreshDataGridViewAppointments.Click += new System.EventHandler(this.BtnRefreshDataGridViewAppointments_Click);
            // 
            // btnDeleteAppointment
            // 
            this.btnDeleteAppointment.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeleteAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAppointment.Location = new System.Drawing.Point(89, 598);
            this.btnDeleteAppointment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteAppointment.Name = "btnDeleteAppointment";
            this.btnDeleteAppointment.Size = new System.Drawing.Size(140, 36);
            this.btnDeleteAppointment.TabIndex = 9;
            this.btnDeleteAppointment.Text = "Delete";
            this.btnDeleteAppointment.UseVisualStyleBackColor = false;
            this.btnDeleteAppointment.Click += new System.EventHandler(this.BtnDeleteAppointment_Click);
            // 
            // dataGridViewAppointments
            // 
            this.dataGridViewAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewAppointments.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAppointments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAppointments.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewAppointments.Location = new System.Drawing.Point(90, 182);
            this.dataGridViewAppointments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewAppointments.Name = "dataGridViewAppointments";
            this.dataGridViewAppointments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewAppointments.RowHeadersVisible = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewAppointments.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAppointments.Size = new System.Drawing.Size(560, 388);
            this.dataGridViewAppointments.TabIndex = 0;
            this.dataGridViewAppointments.DoubleClick += new System.EventHandler(this.ViewPatientInforThroughAppointments_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnRefreshPatientArchive);
            this.tabPage1.Controls.Add(this.btnSearchPatientArchive);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtSearchFirstNamePA);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtSearchLastNamePA);
            this.tabPage1.Controls.Add(this.dataGridViewPArchive);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(728, 714);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Patient Archive";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRefreshPatientArchive
            // 
            this.btnRefreshPatientArchive.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRefreshPatientArchive.Location = new System.Drawing.Point(75, 591);
            this.btnRefreshPatientArchive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefreshPatientArchive.Name = "btnRefreshPatientArchive";
            this.btnRefreshPatientArchive.Size = new System.Drawing.Size(118, 44);
            this.btnRefreshPatientArchive.TabIndex = 87;
            this.btnRefreshPatientArchive.Text = "Refresh";
            this.btnRefreshPatientArchive.UseVisualStyleBackColor = false;
            this.btnRefreshPatientArchive.Click += new System.EventHandler(this.btnRefreshPatientArchive_Click);
            // 
            // btnSearchPatientArchive
            // 
            this.btnSearchPatientArchive.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearchPatientArchive.Location = new System.Drawing.Point(75, 48);
            this.btnSearchPatientArchive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchPatientArchive.Name = "btnSearchPatientArchive";
            this.btnSearchPatientArchive.Size = new System.Drawing.Size(118, 36);
            this.btnSearchPatientArchive.TabIndex = 84;
            this.btnSearchPatientArchive.Text = "Search";
            this.btnSearchPatientArchive.UseVisualStyleBackColor = false;
            this.btnSearchPatientArchive.Click += new System.EventHandler(this.btnSearchPatientArchive_Click);
            // 
            // label7
            // 
            this.label7.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 94);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 15);
            this.label7.TabIndex = 83;
            this.label7.Text = "First Name:";
            // 
            // txtSearchFirstNamePA
            // 
            this.txtSearchFirstNamePA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchFirstNamePA.Location = new System.Drawing.Point(166, 94);
            this.txtSearchFirstNamePA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchFirstNamePA.Name = "txtSearchFirstNamePA";
            this.txtSearchFirstNamePA.Size = new System.Drawing.Size(145, 22);
            this.txtSearchFirstNamePA.TabIndex = 82;
            // 
            // label8
            // 
            this.label8.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(376, 94);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 15);
            this.label8.TabIndex = 81;
            this.label8.Text = "Last Name:";
            // 
            // txtSearchLastNamePA
            // 
            this.txtSearchLastNamePA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchLastNamePA.Location = new System.Drawing.Point(486, 91);
            this.txtSearchLastNamePA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchLastNamePA.Name = "txtSearchLastNamePA";
            this.txtSearchLastNamePA.Size = new System.Drawing.Size(145, 22);
            this.txtSearchLastNamePA.TabIndex = 80;
            // 
            // dataGridViewPArchive
            // 
            this.dataGridViewPArchive.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewPArchive.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPArchive.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPArchive.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewPArchive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPArchive.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewPArchive.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewPArchive.Location = new System.Drawing.Point(75, 158);
            this.dataGridViewPArchive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewPArchive.Name = "dataGridViewPArchive";
            this.dataGridViewPArchive.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPArchive.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewPArchive.RowHeadersVisible = false;
            this.dataGridViewPArchive.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewPArchive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPArchive.Size = new System.Drawing.Size(569, 408);
            this.dataGridViewPArchive.TabIndex = 9;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(856, 861);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.LoadForm);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPatients.ResumeLayout(false);
            this.tabPatients.PerformLayout();
            this.tabConsultations.ResumeLayout(false);
            this.tabConsultations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultations)).EndInit();
            this.AppointmentsTab.ResumeLayout(false);
            this.AppointmentsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPArchive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.DataGridView dataGridViewPatients;
        private System.Windows.Forms.TextBox txtSearchLastName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPatients;
        private System.Windows.Forms.TabPage tabConsultations;
        private System.Windows.Forms.DataGridView dataGridViewConsultations;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSearchFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateOfConsultationPicker;
        private System.Windows.Forms.Button btnViewConsultations;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage AppointmentsTab;
        private System.Windows.Forms.DataGridView dataGridViewAppointments;
        private System.Windows.Forms.Button btnDeletePatient;
        private System.Windows.Forms.Button btnDeleteAppointment;
        private System.Windows.Forms.Button btnRefreshDataGridViewAppointments;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerAppointment;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewPArchive;
        private System.Windows.Forms.Button btnSearchPatientArchive;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearchFirstNamePA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSearchLastNamePA;
        private System.Windows.Forms.Button btnRefreshPatientArchive;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.RadioButton radioMale;
    }
}

