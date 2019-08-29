using FuaClinic.Business;
using FuaClinic.Business.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ConsultationForms
{
    public partial class AddConsultation : Form
    {
        ConsultationRepository consulationRepository = new ConsultationRepository();
        Patient patient;
        public AddConsultation(Patient patient)
        {
            InitializeComponent();
            this.patient = patient;
        }

        private void btnSaveConsulltation_Click(object sender, EventArgs e)
        {
            if (txtDiagnosis.Text.Trim() == string.Empty || dateTimePickerDateOfConsultation.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Plesase fill up all fields.");
            }
            else
            {
                var consultation = new Consultation();
                consultation.PatientId = patient.Id;
                consultation.Diagnosis = txtDiagnosis.Text;
                consultation.Date = dateTimePickerDateOfConsultation.Text;

                if (consulationRepository.Add(consultation) > 0)
                {
                    MessageBox.Show("Consultation saved successfully");
                }
                this.Close();
            }
        }
    }
}
