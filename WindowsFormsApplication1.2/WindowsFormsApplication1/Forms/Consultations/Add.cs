using FuaClinic.Business;
using FuaClinic.Business.Managers;
using FuaClinic.Business.Managers.ManagerInterfaces;
using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ConsultationForms
{
    public partial class Add : Form
    {
        private IConsultationManager consultationManager;
        Consultation consultation;

        public Add(Consultation consultation, IConsultationManager consultationManager)
        {
            InitializeComponent();
            this.consultation = consultation;
            this.consultationManager = consultationManager;
        }

        private void SaveConsultation(object sender, EventArgs e)
        {
            if (AreTextBoxesFilled())
            {
                AddConsultation(consultation);
                this.Close();
            }
        }

        public void AddConsultation(Consultation consultation)
        {
            consultation.Diagnosis = txtDiagnosis.Text;
            consultation.Date = dateTimePickerDateOfConsultation.Value.Date;

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
    }
}
