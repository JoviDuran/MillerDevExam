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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtFirstNameAppointment = new System.Windows.Forms.TextBox();
            this.lblFirstNameAppointment = new System.Windows.Forms.Label();
            this.txtLastNameAppointment = new System.Windows.Forms.TextBox();
            this.lblLastNameAppointment = new System.Windows.Forms.Label();
            this.lblDateAppointment = new System.Windows.Forms.Label();
            this.btnSaveAppointment = new System.Windows.Forms.Button();
            this.dateTimePickerAppointment = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewAppointments = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnPatientsAppointments = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFirstNameAppointment
            // 
            this.txtFirstNameAppointment.Location = new System.Drawing.Point(161, 39);
            this.txtFirstNameAppointment.Name = "txtFirstNameAppointment";
            this.txtFirstNameAppointment.ReadOnly = true;
            this.txtFirstNameAppointment.Size = new System.Drawing.Size(158, 20);
            this.txtFirstNameAppointment.TabIndex = 109;
            // 
            // lblFirstNameAppointment
            // 
            this.lblFirstNameAppointment.AutoSize = true;
            this.lblFirstNameAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNameAppointment.Location = new System.Drawing.Point(33, 43);
            this.lblFirstNameAppointment.Name = "lblFirstNameAppointment";
            this.lblFirstNameAppointment.Size = new System.Drawing.Size(73, 16);
            this.lblFirstNameAppointment.TabIndex = 108;
            this.lblFirstNameAppointment.Text = "First Name";
            // 
            // txtLastNameAppointment
            // 
            this.txtLastNameAppointment.Location = new System.Drawing.Point(161, 69);
            this.txtLastNameAppointment.Name = "txtLastNameAppointment";
            this.txtLastNameAppointment.ReadOnly = true;
            this.txtLastNameAppointment.Size = new System.Drawing.Size(158, 20);
            this.txtLastNameAppointment.TabIndex = 111;
            // 
            // lblLastNameAppointment
            // 
            this.lblLastNameAppointment.AutoSize = true;
            this.lblLastNameAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastNameAppointment.Location = new System.Drawing.Point(34, 67);
            this.lblLastNameAppointment.Name = "lblLastNameAppointment";
            this.lblLastNameAppointment.Size = new System.Drawing.Size(73, 16);
            this.lblLastNameAppointment.TabIndex = 110;
            this.lblLastNameAppointment.Text = "Last Name";
            // 
            // lblDateAppointment
            // 
            this.lblDateAppointment.AutoSize = true;
            this.lblDateAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateAppointment.Location = new System.Drawing.Point(34, 94);
            this.lblDateAppointment.Name = "lblDateAppointment";
            this.lblDateAppointment.Size = new System.Drawing.Size(72, 16);
            this.lblDateAppointment.TabIndex = 112;
            this.lblDateAppointment.Text = "Date/Time";
            // 
            // btnSaveAppointment
            // 
            this.btnSaveAppointment.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSaveAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAppointment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaveAppointment.Location = new System.Drawing.Point(212, 133);
            this.btnSaveAppointment.Name = "btnSaveAppointment";
            this.btnSaveAppointment.Size = new System.Drawing.Size(107, 31);
            this.btnSaveAppointment.TabIndex = 116;
            this.btnSaveAppointment.Text = "Save";
            this.btnSaveAppointment.UseVisualStyleBackColor = false;
            this.btnSaveAppointment.Click += new System.EventHandler(this.btnSaveAppointment_Click);
            // 
            // dateTimePickerAppointment
            // 
            this.dateTimePickerAppointment.CustomFormat = "yyyy-MM-dd hh:mm:ss tt";
            this.dateTimePickerAppointment.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAppointment.Location = new System.Drawing.Point(161, 95);
            this.dateTimePickerAppointment.Name = "dateTimePickerAppointment";
            this.dateTimePickerAppointment.Size = new System.Drawing.Size(159, 20);
            this.dateTimePickerAppointment.TabIndex = 117;
            this.dateTimePickerAppointment.Value = new System.DateTime(2019, 1, 1, 12, 0, 0, 0);
            this.dateTimePickerAppointment.ValueChanged += new System.EventHandler(this.dateTimePickerAppointment_ValueChanged);
            this.dateTimePickerAppointment.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dateTimePickerAppointment_KeyUp);
            // 
            // dataGridViewAppointments
            // 
            this.dataGridViewAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridViewAppointments.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAppointments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAppointments.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAppointments.Location = new System.Drawing.Point(399, 83);
            this.dataGridViewAppointments.Name = "dataGridViewAppointments";
            this.dataGridViewAppointments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAppointments.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAppointments.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewAppointments.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAppointments.Size = new System.Drawing.Size(386, 293);
            this.dataGridViewAppointments.TabIndex = 118;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRefresh.Location = new System.Drawing.Point(37, 133);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(107, 31);
            this.btnRefresh.TabIndex = 119;
            this.btnRefresh.Text = "Clear";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPatientsAppointments
            // 
            this.btnPatientsAppointments.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPatientsAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientsAppointments.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPatientsAppointments.Location = new System.Drawing.Point(399, 39);
            this.btnPatientsAppointments.Name = "btnPatientsAppointments";
            this.btnPatientsAppointments.Size = new System.Drawing.Size(188, 31);
            this.btnPatientsAppointments.TabIndex = 120;
            this.btnPatientsAppointments.Text = "Patient\'s History";
            this.btnPatientsAppointments.UseVisualStyleBackColor = false;
            this.btnPatientsAppointments.Click += new System.EventHandler(this.btnPatientsAppointments_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(939, 436);
            this.Controls.Add(this.btnPatientsAppointments);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridViewAppointments);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridViewAppointments;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnPatientsAppointments;
    }
}