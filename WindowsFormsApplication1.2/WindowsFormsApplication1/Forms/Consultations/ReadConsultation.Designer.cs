namespace WindowsFormsApplication1.ConsultationForms
{
    partial class ReadConsultation
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
            this.lblConsultations = new System.Windows.Forms.Label();
            this.dataGridViewConsultations = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAddConsultation = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dateOfConsultationPicker = new System.Windows.Forms.DateTimePicker();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.btnViewAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultations)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConsultations
            // 
            this.lblConsultations.AutoSize = true;
            this.lblConsultations.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultations.Location = new System.Drawing.Point(26, 34);
            this.lblConsultations.Name = "lblConsultations";
            this.lblConsultations.Size = new System.Drawing.Size(158, 24);
            this.lblConsultations.TabIndex = 125;
            this.lblConsultations.Text = "Consultations of";
            // 
            // dataGridViewConsultations
            // 
            this.dataGridViewConsultations.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewConsultations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsultations.Location = new System.Drawing.Point(142, 197);
            this.dataGridViewConsultations.Name = "dataGridViewConsultations";
            this.dataGridViewConsultations.Size = new System.Drawing.Size(228, 217);
            this.dataGridViewConsultations.TabIndex = 126;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(187, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(28, 24);
            this.lblName.TabIndex = 127;
            this.lblName.Text = "   ";
            // 
            // btnAddConsultation
            // 
            this.btnAddConsultation.BackColor = System.Drawing.Color.Green;
            this.btnAddConsultation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddConsultation.Location = new System.Drawing.Point(158, 429);
            this.btnAddConsultation.Name = "btnAddConsultation";
            this.btnAddConsultation.Size = new System.Drawing.Size(57, 37);
            this.btnAddConsultation.TabIndex = 143;
            this.btnAddConsultation.Text = "Add";
            this.btnAddConsultation.UseVisualStyleBackColor = false;
            this.btnAddConsultation.Click += new System.EventHandler(this.btnAddConsultation_Click);
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(154, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 144;
            this.label6.Text = "Date:";
            // 
            // dateOfConsultationPicker
            // 
            this.dateOfConsultationPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOfConsultationPicker.Location = new System.Drawing.Point(229, 158);
            this.dateOfConsultationPicker.Name = "dateOfConsultationPicker";
            this.dateOfConsultationPicker.Size = new System.Drawing.Size(131, 20);
            this.dateOfConsultationPicker.TabIndex = 145;
            this.dateOfConsultationPicker.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dateOfConsultationPicker_KeyUp);
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.Location = new System.Drawing.Point(191, 34);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(22, 24);
            this.lblPatientName.TabIndex = 146;
            this.lblPatientName.Text = "  ";
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(140, 114);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(75, 31);
            this.btnViewAll.TabIndex = 147;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // ReadConsultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(509, 561);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.dateOfConsultationPicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAddConsultation);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dataGridViewConsultations);
            this.Controls.Add(this.lblConsultations);
            this.Name = "ReadConsultation";
            this.Text = "Consultations";
            this.Load += new System.EventHandler(this.ReadConsultation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsultations;
        private System.Windows.Forms.DataGridView dataGridViewConsultations;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAddConsultation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateOfConsultationPicker;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Button btnViewAll;
    }
}