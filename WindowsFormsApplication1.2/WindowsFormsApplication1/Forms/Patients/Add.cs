using System;
using System.Windows.Forms;
using FuaClinic.Business;
using FuaClinic.Business.Managers;
using FuaClinic.Business.Managers.ManagerInterfaces;

namespace WindowsFormsApplication1
{
    public partial class Add : Form
    {
        private IPatientManager patientManager;
        private IEmergencyContactManager emergencyContactManager;
        private IConsultationManager consultationManager;
        private IAddressManager addressManager;

        public Add(IPatientManager patientManager, IEmergencyContactManager emergencyContactManager, IConsultationManager consultationManager, IAddressManager addressManager)
        {
            InitializeComponent();
            this.patientManager = patientManager;
            this.emergencyContactManager = emergencyContactManager;
            this.consultationManager = consultationManager;
            this.addressManager = addressManager;
        }
       

        private void Save(object sender, EventArgs e)
        {
            if (areTextBoxesFilled())
            {
                var patientId = patientManager.Add(CreatePatient());
                addressManager.Add(CreateAddress(patientId));
                emergencyContactManager.Add(CreateEmergencyContact(patientId)); 
                consultationManager.Add(CreateConsultation(patientId));
                MessageBox.Show("Patient data saved successfully");
                this.Close();
            }
        }

        public Patient CreatePatient()
        {
            var patient = new Patient();
            patient.LastName = txtLastName.Text;
            patient.FirstName = txtFirstName.Text;
            patient.Gender = txtGender.Text;
            patient.BirthDate = Convert.ToDateTime(dateTimePickerBirthDate.Value);
            patient.Occupation = txtOccupation.Text;
            patient.Email = txtEmail.Text;
            patient.ContactNumber = txtContactNumber.Text;
            return patient;
        }

        public Address CreateAddress(int patientId)
        {
            var address = new Address();
            address.PatientId = patientId;
            address.City = txtCity.Text;
            address.Province = txtProvince.Text;
            address.PostalCode = txtPostalCode.Text;
            return address;
        }

        public EmergencyContact CreateEmergencyContact(int patientId)
        {
            var emergencyContact = new EmergencyContact();
            emergencyContact.PatientId = patientId;
            emergencyContact.FirstName = txtEcFirstname.Text;
            emergencyContact.LastName = txtECLastName.Text;
            emergencyContact.ContactNumber = txtECContactNumber.Text;
            return emergencyContact;
        }

        public Consultation CreateConsultation(int patientId)
        {
            var consultation = new Consultation();
            consultation.PatientId = patientId;
            consultation.Diagnosis = txtDiagnosis.Text;
            consultation.Date = dateTimePickerDateOfConsultation.Value;
            return consultation;
        }

        public bool areTextBoxesFilled()
        {
            if (txtFirstName.Text.Trim() == string.Empty ||
               txtLastName.Text.Trim() == string.Empty ||
               txtGender.Text.Trim() == string.Empty ||
               dateTimePickerBirthDate.Text.Trim() == string.Empty ||
               txtEmail.Text.Trim() == string.Empty ||
               txtOccupation.Text.Trim() == string.Empty ||
               txtContactNumber.Text.Trim() == string.Empty ||
               txtCity.Text.Trim() == string.Empty ||
               txtProvince.Text.Trim() == string.Empty ||
               txtPostalCode.Text.Trim() == string.Empty ||
               txtEcFirstname.Text.Trim() == string.Empty ||
               txtECLastName.Text.Trim() == string.Empty ||
               txtECContactNumber.Text.Trim() == string.Empty ||
               txtDiagnosis.Text.Trim() == string.Empty ||
               dateTimePickerDateOfConsultation.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill up all fields.");
                return false;
            }
            return true;
        }

        private void ClearFields_Click(object sender, EventArgs e)
        {
            txtLastName.Text = txtFirstName.Text = txtOccupation.Text =
            txtEmail.Text = txtOccupation.Text = dateTimePickerBirthDate.Text =
            txtContactNumber.Text = txtCity.Text = txtProvince.Text =
            txtPostalCode.Text = txtEcFirstname.Text = txtECLastName.Text =
            txtECContactNumber.Text = txtDiagnosis.Text =
            dateTimePickerDateOfConsultation.Text = string.Empty;
        }
    }
}
