using System;
using System.Windows.Forms;
using FuaClinic.Business;
using FuaClinic.Business.Managers;
using System.Linq;
using FuaClinic.Business.Managers.ManagerInterfaces;

namespace WindowsFormsApplication1
{
    public partial class Read : Form
    {
        private readonly IPatientManager patientManager;
        private readonly IAddressManager addressManager;
        private readonly IEmergencyContactManager emergencyContactManager;
        private readonly ITestResultManager testResultManager;

        Patient patient;

        public Read(Patient patient, IPatientManager patientManager, 
            IAddressManager addressManager, 
            IEmergencyContactManager emergencyContactManager,
            ITestResultManager testResultManager
            )
        {
            InitializeComponent();
            this.patient = patient;
            this.patientManager = patientManager;
            this.addressManager = addressManager;
            this.emergencyContactManager = emergencyContactManager;
            this.testResultManager = testResultManager;
        }

        private void PatientInformation_Load(object sender, EventArgs e)
        {
            txtFirstName.Text = patient.FirstName;
            txtLastName.Text = patient.LastName;
            txtGender.Text = patient.Gender;
            dateTimePickerBirthDate.Text = patient.BirthDate.ToString();
            txtContactNumber.Text = patient.ContactNumber;
            txtEmail.Text = patient.Email;
            txtOccupation.Text = patient.Occupation;

            var address = addressManager.GetWithWhereCondition<Address>($"PatientID = {patient.Id}").FirstOrDefault();

            if (address != null)
            {
                txtCity.Text = address.City;
                txtProvince.Text = address.Province;
                txtPostalCode.Text = address.PostalCode;
            }
            else
            {
                txtCity.Text = txtProvince.Text = txtPostalCode.Text = string.Empty;
            }


            var emergencyContact = emergencyContactManager.GetWithWhereCondition<EmergencyContact>($"PatientId = {patient.Id}").FirstOrDefault();

            if (emergencyContact != null)
            {
                txtEcFirstname.Text = emergencyContact.FirstName;
                txtECLastName.Text = emergencyContact.LastName;
                txtECContactNum.Text = emergencyContact.ContactNumber;
            }
            else
            {
                txtEcFirstname.Text = txtECLastName.Text = txtECContactNum.Text = string.Empty;
            }
        }



        private void Update(object sender, EventArgs e)
        {
            patient.FirstName = txtFirstName.Text;
            patient.LastName = txtLastName.Text;
            patient.Gender = txtGender.Text;
            patient.BirthDate = Convert.ToDateTime(dateTimePickerBirthDate.Value.Date);
            patient.Occupation = txtOccupation.Text;
            patient.Email = txtEmail.Text;
            patient.ContactNumber = txtContactNumber.Text;

            var address = addressManager.GetWithWhereCondition<Address>($"PatientId = {patient.Id}").FirstOrDefault();
            address.PatientId = patient.Id;
            address.City = txtCity.Text;
            address.Province = txtProvince.Text;
            address.PostalCode = txtPostalCode.Text;

            var emergencyContact = emergencyContactManager.GetWithWhereCondition<EmergencyContact>($"PatientId = {patient.Id}").FirstOrDefault();
            emergencyContact.PatientId = patient.Id;
            emergencyContact.FirstName = txtEcFirstname.Text;
            emergencyContact.LastName = txtECLastName.Text;
            emergencyContact.ContactNumber = txtECContactNum.Text;

            if (patientManager.Update(patient) && addressManager.Update(address) && emergencyContactManager.Update(emergencyContact))
            {
                MessageBox.Show("Updated succesfully.");
            }
        }

        private void btnConsultations_Click(object sender, EventArgs e)
        {
            var consultationManager = new ConsultationManager();
            new Forms.Consultations.Read(patient, consultationManager).Show();
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            var appointmentManager = new AppointmentManager();
            new Forms.Appointments.Read(patient, patientManager, appointmentManager, testResultManager).Show();
        }
    }
}
