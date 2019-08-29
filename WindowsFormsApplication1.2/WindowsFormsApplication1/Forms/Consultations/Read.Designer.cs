namespace WindowsFormsApplication1.ConsultationForms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultations)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewConsultations
            // 
            this.dataGridViewConsultations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewConsultations.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewConsultations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewConsultations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewConsultations.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewConsultations.Location = new System.Drawing.Point(224, 172);
            this.dataGridViewConsultations.Name = "dataGridViewConsultations";
            this.dataGridViewConsultations.RowHeadersVisible = false;
            this.dataGridViewConsultations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewConsultations.Size = new System.Drawing.Size(143, 217);
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
            this.btnAddConsultation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddConsultation.Location = new System.Drawing.Point(84, 176);
            this.btnAddConsultation.Name = "btnAddConsultation";
            this.btnAddConsultation.Size = new System.Drawing.Size(105, 37);
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
            this.label6.Location = new System.Drawing.Point(221, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 144;
            this.label6.Text = "Date:";
            // 
            // dateOfConsultationPicker
            // 
            this.dateOfConsultationPicker.CustomFormat = "yyyy-MM-dd";
            this.dateOfConsultationPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOfConsultationPicker.Location = new System.Drawing.Point(267, 136);
            this.dateOfConsultationPicker.Name = "dateOfConsultationPicker";
            this.dateOfConsultationPicker.Size = new System.Drawing.Size(100, 20);
            this.dateOfConsultationPicker.TabIndex = 145;
            this.dateOfConsultationPicker.ValueChanged += new System.EventHandler(this.dateOfConsultationPicker_ValueChanged);
            this.dateOfConsultationPicker.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dateOfConsultationPicker_KeyUp);
            // 
            // btnViewAll
            // 
            this.btnViewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAll.Location = new System.Drawing.Point(84, 133);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(107, 31);
            this.btnViewAll.TabIndex = 147;
            this.btnViewAll.Text = "Refresh";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // btnDeleteConsultation
            // 
            this.btnDeleteConsultation.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteConsultation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteConsultation.Location = new System.Drawing.Point(86, 219);
            this.btnDeleteConsultation.Name = "btnDeleteConsultation";
            this.btnDeleteConsultation.Size = new System.Drawing.Size(105, 37);
            this.btnDeleteConsultation.TabIndex = 148;
            this.btnDeleteConsultation.Text = "Delete";
            this.btnDeleteConsultation.UseVisualStyleBackColor = false;
            this.btnDeleteConsultation.Click += new System.EventHandler(this.BtnDeleteConsultation_Click);
            // 
            // txtLastNameConsultation
            // 
            this.txtLastNameConsultation.Location = new System.Drawing.Point(224, 104);
            this.txtLastNameConsultation.Name = "txtLastNameConsultation";
            this.txtLastNameConsultation.ReadOnly = true;
            this.txtLastNameConsultation.Size = new System.Drawing.Size(143, 20);
            this.txtLastNameConsultation.TabIndex = 152;
            // 
            // lblLastNameAppointment
            // 
            this.lblLastNameAppointment.AutoSize = true;
            this.lblLastNameAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastNameAppointment.Location = new System.Drawing.Point(104, 108);
            this.lblLastNameAppointment.Name = "lblLastNameAppointment";
            this.lblLastNameAppointment.Size = new System.Drawing.Size(73, 16);
            this.lblLastNameAppointment.TabIndex = 151;
            this.lblLastNameAppointment.Text = "Last Name";
            // 
            // txtFirstNameConsultation
            // 
            this.txtFirstNameConsultation.Location = new System.Drawing.Point(224, 74);
            this.txtFirstNameConsultation.Name = "txtFirstNameConsultation";
            this.txtFirstNameConsultation.ReadOnly = true;
            this.txtFirstNameConsultation.Size = new System.Drawing.Size(143, 20);
            this.txtFirstNameConsultation.TabIndex = 150;
            // 
            // lblFirstNameAppointment
            // 
            this.lblFirstNameAppointment.AutoSize = true;
            this.lblFirstNameAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNameAppointment.Location = new System.Drawing.Point(104, 75);
            this.lblFirstNameAppointment.Name = "lblFirstNameAppointment";
            this.lblFirstNameAppointment.Size = new System.Drawing.Size(73, 16);
            this.lblFirstNameAppointment.TabIndex = 149;
            this.lblFirstNameAppointment.Text = "First Name";
            // 
            // Read
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(509, 561);
            this.Controls.Add(this.txtLastNameConsultation);
            this.Controls.Add(this.lblLastNameAppointment);
            this.Controls.Add(this.txtFirstNameConsultation);
            this.Controls.Add(this.lblFirstNameAppointment);
            this.Controls.Add(this.btnDeleteConsultation);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.dateOfConsultationPicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAddConsultation);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dataGridViewConsultations);
            this.Name = "Read";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultations";
            this.Load += new System.EventHandler(this.Read_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultations)).EndInit();
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
    }
}