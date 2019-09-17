using FuaClinic.Business;
using FuaClinic.Business.Managers;
using FuaClinic.Business.Managers.ManagerInterfaces;
using FuaClinic.Business.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Forms.Consultations
{
    public partial class Add : Form
    {
        private IConsultationManager consultationManager;
        AppointmentManager appointmentManager = new AppointmentManager();
        Patient patient;
        public Add(Patient patient, IConsultationManager consultationManager)
        {
            InitializeComponent();
            this.patient = patient;
            this.consultationManager = consultationManager;
        }

        private void SaveConsultation(object sender, EventArgs e)
        {
            if (AreTextBoxesFilled())
            {
                AddConsultation(CreateConsultation());
                this.Close();
            }

        }

        public Appointment GetAppointment()
        {
            var i = appointmentManager.GetWithWhereCondition<Appointment>
                ($"PatientId = {patient.Id} and DesiredDateTime = '{dateTimePickerDateOfConsultation.Value.ToString("yyyy-MM-dd hh:mm:ss")}'").FirstOrDefault();
            return i;
        }

        public Consultation CreateConsultation()
        {
            var appointment = GetAppointment();
            var consultation = new Consultation
            {
                PatientId = patient.Id,
                Diagnosis = txtDiagnosis.Text,
                DateTime = dateTimePickerDateOfConsultation.Value,
            };

            if (appointment != null)
            {
                consultation.AppointmentId = appointment.Id;
            }
            else
            {
                consultation.AppointmentId = null;
            }

            return consultation;
        }

        public void AddConsultation(Consultation consultation)
        {
            if (consultationManager.Add(consultation) > 0)
            {
                MessageBox.Show("Consultation saved successfully");
            }
        }

        public bool AreTextBoxesFilled()
        {
            if (txtDiagnosis.Text.Trim() == string.Empty || dateTimePickerDateOfConsultation.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Plesase fill up all fields.");
                return false;
            }
            return true;
        }

        private void dateTimePickerDateOfConsultation_ValueChanged(object sender, EventArgs e)
        {
            var appointment = GetAppointment();
            textBox1.Text = appointment.DesiredDateTime.ToString();

        }

        private void dateTimePickerDateOfConsultation_KeyUp(object sender, KeyEventArgs e)
        {
            var appointment = GetAppointment();
            if (appointment != null)
            {
                textBox1.Text = appointment.DesiredDateTime.ToString();
            }
        }
    }
}
