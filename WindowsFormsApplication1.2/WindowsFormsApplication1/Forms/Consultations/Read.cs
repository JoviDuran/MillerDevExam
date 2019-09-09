using System;
using System.Windows.Forms;
using FuaClinic.Business;
using Dapper;
using FuaClinic.Business.Managers;
using System.Collections.Generic;
using FuaClinic.Business.Managers.ManagerInterfaces;

namespace WindowsFormsApplication1.Forms.Consultations
{
    public partial class Read : Form
    {
        private IConsultationManager consultationManager; 
        Patient patient;

        public Read(Patient patient, IConsultationManager consultationManager)
        {
            InitializeComponent();
            this.patient = patient;
            this.consultationManager = consultationManager;
        }

        private void Read_Load(object sender, EventArgs e)
        {
            txtFirstNameConsultation.Text = patient.FirstName;
            txtLastNameConsultation.Text = patient.LastName;
            FillDataGridConsultations();
            ShowImportanColumnsOfDataGridViewConsultations();
            txtFirstNameConsultation.ReadOnly = true;
            txtLastNameConsultation.ReadOnly = true;


        }

        private void Add(object sender, EventArgs e)
        {
            var consultation = new Consultation();
            consultation.PatientId = patient.Id;
            new Add(consultation, consultationManager).Show();
        }

        private void dateOfConsultationPicker_KeyUp(object sender, KeyEventArgs e)
        {
            FillDataGridConsultationsByDate();
        }
        private void dateOfConsultationPicker_ValueChanged(object sender, EventArgs e)
        {
            FillDataGridConsultationsByDate();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            FillDataGridConsultations();
            ShowImportanColumnsOfDataGridViewConsultations();
        }
        public void FillDataGridConsultations()
        {
            dataGridViewConsultations.DataSource = consultationManager.GetByPatientId(patient.Id);
        }

        private void BtnDeleteConsultation_Click(object sender, EventArgs e)
        {
            DeleteConsultation();
            FillDataGridConsultations();
            ShowImportanColumnsOfDataGridViewConsultations();
        }

        public void DeleteConsultation()
        {
            if (dataGridViewConsultations.SelectedRows.Count > 0)
            {
                var ids = new List<int>();
                foreach (DataGridViewRow row in dataGridViewConsultations.SelectedRows)
                {
                    ids.Add(Convert.ToInt32(row.Cells[0].Value.ToString()));
                }
                var messageBoxResult = MessageBox.Show("Are you sure you want to delete?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (messageBoxResult == DialogResult.Yes)
                {
                    if (consultationManager.Delete(ids.ToArray()))
                    {
                        MessageBox.Show("Deleted Succesfully");
                    }
                }
            }
        }
        public void FillDataGridConsultationsByDate()
        {
            var parameter = new DynamicParameters();
            parameter.Add("@SearchText", dateOfConsultationPicker.Text.Trim());
            dataGridViewConsultations.DataSource = consultationManager.GetByDate(parameter);
            ShowImportanColumnsOfDataGridViewConsultations();
        }

        public void ShowImportanColumnsOfDataGridViewConsultations()
        {
            dataGridViewConsultations.Columns[0].Visible = false;
            dataGridViewConsultations.Columns[1].Visible = false;
        }
    }
}
