namespace WindowsFormsApplication1.Forms.Consultations
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewConsultations = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAddConsultation = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dateOfConsultationPicker = new System.Windows.Forms.DateTimePicker();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnDeleteConsultation = new System.Windows.Forms.Button();
            this.txtLastNameConsultation = new System.Windows.Forms.TextBox();
            this.lblLastNameAppointment = new System.Windows.Forms.Label();
            this.txtFirstNameConsultation = new System.Windows.Forms.TextBox();
            this.lblFirstNameAppointment = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultations)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewConsultations
            // 
            this.dataGridViewConsultations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewConsultations.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewConsultations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewConsultations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewConsultations.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewConsultations.Location = new System.Drawing.Point(341, 58);
            this.dataGridViewConsultations.Name = "dataGridViewConsultations";
            this.dataGridViewConsultations.RowHeadersVisible = false;
            this.dataGridViewConsultations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewConsultations.Size = new System.Drawing.Size(209, 221);
            this.dataGridViewConsultations.TabIndex = 126;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(14, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(28, 24);
            this.lblName.TabIndex = 127;
            this.lblName.Text = "   ";
            // 
            // btnAddConsultation
            // 
            this.btnAddConsultation.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddConsultation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddConsultation.Location = new System.Drawing.Point(140, 364);
            this.btnAddConsultation.Name = "btnAddConsultation";
            this.btnAddConsultation.Size = new System.Drawing.Size(95, 28);
            this.btnAddConsultation.TabIndex = 143;
            this.btnAddConsultation.Text = "Add";
            this.btnAddConsultation.UseVisualStyleBackColor = false;
            this.btnAddConsultation.Click += new System.EventHandler(this.Add);
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 144;
            this.label6.Text = "Date:";
            // 
            // dateOfConsultationPicker
            // 
            this.dateOfConsultationPicker.CustomFormat = "yyyy-MM-dd";
            this.dateOfConsultationPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOfConsultationPicker.Location = new System.Drawing.Point(137, 83);
            this.dateOfConsultationPicker.Name = "dateOfConsultationPicker";
            this.dateOfConsultationPicker.Size = new System.Drawing.Size(143, 20);
            this.dateOfConsultationPicker.TabIndex = 145;
            this.dateOfConsultationPicker.ValueChanged += new System.EventHandler(this.dateOfConsultationPicker_ValueChanged);
            this.dateOfConsultationPicker.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dateOfConsultationPicker_KeyUp);
            // 
            // btnViewAll
            // 
            this.btnViewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAll.Location = new System.Drawing.Point(349, 363);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(89, 31);
            this.btnViewAll.TabIndex = 147;
            this.btnViewAll.Text = "Refresh";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // btnDeleteConsultation
            // 
            this.btnDeleteConsultation.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteConsultation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteConsultation.Location = new System.Drawing.Point(248, 364);
            this.btnDeleteConsultation.Name = "btnDeleteConsultation";
            this.btnDeleteConsultation.Size = new System.Drawing.Size(95, 28);
            this.btnDeleteConsultation.TabIndex = 148;
            this.btnDeleteConsultation.Text = "Delete";
            this.btnDeleteConsultation.UseVisualStyleBackColor = false;
            this.btnDeleteConsultation.Click += new System.EventHandler(this.BtnDeleteConsultation_Click);
            // 
            // txtLastNameConsultation
            // 
            this.txtLastNameConsultation.Location = new System.Drawing.Point(137, 51);
            this.txtLastNameConsultation.Name = "txtLastNameConsultation";
            this.txtLastNameConsultation.ReadOnly = true;
            this.txtLastNameConsultation.Size = new System.Drawing.Size(143, 20);
            this.txtLastNameConsultation.TabIndex = 152;
            // 
            // lblLastNameAppointment
            // 
            this.lblLastNameAppointment.AutoSize = true;
            this.lblLastNameAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastNameAppointment.Location = new System.Drawing.Point(17, 55);
            this.lblLastNameAppointment.Name = "lblLastNameAppointment";
            this.lblLastNameAppointment.Size = new System.Drawing.Size(73, 16);
            this.lblLastNameAppointment.TabIndex = 151;
            this.lblLastNameAppointment.Text = "Last Name";
            // 
            // txtFirstNameConsultation
            // 
            this.txtFirstNameConsultation.Location = new System.Drawing.Point(137, 21);
            this.txtFirstNameConsultation.Name = "txtFirstNameConsultation";
            this.txtFirstNameConsultation.ReadOnly = true;
            this.txtFirstNameConsultation.Size = new System.Drawing.Size(143, 20);
            this.txtFirstNameConsultation.TabIndex = 150;
            // 
            // lblFirstNameAppointment
            // 
            this.lblFirstNameAppointment.AutoSize = true;
            this.lblFirstNameAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNameAppointment.Location = new System.Drawing.Point(17, 22);
            this.lblFirstNameAppointment.Name = "lblFirstNameAppointment";
            this.lblFirstNameAppointment.Size = new System.Drawing.Size(73, 16);
            this.lblFirstNameAppointment.TabIndex = 149;
            this.lblFirstNameAppointment.Text = "First Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLastNameConsultation);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateOfConsultationPicker);
            this.groupBox1.Controls.Add(this.lblLastNameAppointment);
            this.groupBox1.Controls.Add(this.lblFirstNameAppointment);
            this.groupBox1.Controls.Add(this.txtFirstNameConsultation);
            this.groupBox1.Location = new System.Drawing.Point(18, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 126);
            this.groupBox1.TabIndex = 154;
            this.groupBox1.TabStop = false;
            // 
            // Read
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(583, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDeleteConsultation);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.btnAddConsultation);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dataGridViewConsultations);
            this.Name = "Read";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultations";
            this.Load += new System.EventHandler(this.Read_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultations)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewConsultations;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAddConsultation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateOfConsultationPicker;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Button btnDeleteConsultation;
        private System.Windows.Forms.TextBox txtLastNameConsultation;
        private System.Windows.Forms.Label lblLastNameAppointment;
        private System.Windows.Forms.TextBox txtFirstNameConsultation;
        private System.Windows.Forms.Label lblFirstNameAppointment;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}