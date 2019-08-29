using System;
using System.Data;
using System.Windows.Forms;
using FuaClinic.Business;
using Dapper;
using FuaClinic.Business.Managers;

namespace WindowsFormsApplication1.ConsultationForms
{
    public partial class ReadConsultation : Form
    {
        ConsultationManager consultationManager = new ConsultationManager();
        DataTable dataTable = new DataTable();
        Patient patient;


        public ReadConsultation(Patient patient)
        {
            InitializeComponent();
            this.patient = patient;
        }

        private void ReadConsultation_Load(object sender, EventArgs e)
        {
            //var consultations = consultationRepository.GetByPatientId(patient.Id);
           
            //DataColumn dc2 = new DataColumn("Diagnosis");
            //DataColumn dc3 = new DataColumn("Date");
            //dataTable.Columns.Add(dc2);
            //dataTable.Columns.Add(dc3);
            //dataGridViewConsultations.DataSource = dataTable;

            //foreach (var consultation in consultations)
            //{
            //    DataRow dataRow = dataTable.NewRow();
               
            //    dataRow[0] = consultation.Diagnosis;
            //    dataRow[1] = consultation.Date;
            //    dataTable.Rows.Add(dataRow);
            //}

            //lblName.Text = $"{patient.LastName}, {patient.FirstName}";
            lblPatientName.Text = $"{patient.LastName}, {patient.FirstName}";


        }

        private void btnAddConsultation_Click(object sender, EventArgs e)
        {
            new AddConsultation(patient).Show();
        }
        public void FillDataGridConsultationsByDate()
        {
            var parameter = new DynamicParameters();
            parameter.Add("@SearchText", dateOfConsultationPicker.Text.Trim());
            dataGridViewConsultations.DataSource = consultationManager.GeneratDataTableByDate(parameter);
            dataGridViewConsultations.Columns[0].Visible = false;
            dataGridViewConsultations.Columns[1].Visible = false;
        }

        private void dateOfConsultationPicker_KeyUp(object sender, KeyEventArgs e)
        {
            FillDataGridConsultationsByDate();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            dataGridViewConsultations.DataSource = consultationManager.GenerateDataTableByPatient(patient.Id);
        }
    }
}
