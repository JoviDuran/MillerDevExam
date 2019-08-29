using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dapper;
using FuaClinic.Business.Repositories;
using FuaClinic.Business;
using FuaClinic;
using WindowsFormsApplication1.ConsultationForms;

namespace WindowsFormsApplication1
{
    public partial class ReadUpdateDelete : Form
    {
        PatientRepository patientRepository = new PatientRepository();
        AddressRepository addressRepository = new AddressRepository();
        EmergencyContactRepository emergencyContactRepository = new EmergencyContactRepository();
        ConsultationRepository consultationRepository = new ConsultationRepository();
        public static Patient patient = Home.patient;
        Address address;
        EmergencyContact emergencyContact;

        public ReadUpdateDelete()
        {
            InitializeComponent();
        }

        private void ReadUpdateDelete_Load(object sender, EventArgs e)
        {
            txtFirstName.Text = patient.FirstName;
            txtLastName.Text = patient.LastName;
            txtGender.Text = patient.Gender;
            txtBirthDate.Text = patient.BirthDate;
            txtContactNumber.Text = patient.ContactNumber;
            txtEmail.Text = patient.Email;
            txtOccupation.Text = patient.Occupation;

            address = addressRepository.GetByPatientId(patient.Id);
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


            emergencyContact = emergencyContactRepository.GetByPatientId(patient.Id);


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

        private void btnUpdate(object sender, EventArgs e)
        {
            patient.FirstName = txtFirstName.Text;
            patient.LastName = txtLastName.Text;
            patient.Gender = txtGender.Text;
            patient.BirthDate = txtBirthDate.Text;
            patient.Occupation = txtOccupation.Text;
            patient.Email = txtEmail.Text;
            patient.ContactNumber = txtContactNumber.Text;

            address.PatientId = patient.Id;
            address.City = txtCity.Text;
            address.Province = txtProvince.Text;
            address.PostalCode = txtPostalCode.Text;

            emergencyContact.PatientId = patient.Id;
            emergencyContact.FirstName = txtEcFirstname.Text;
            emergencyContact.LastName = txtECLastName.Text;
            emergencyContact.ContactNumber = txtECContactNum.Text;

            if (patientRepository.Update(patient) > 0 && addressRepository.Update(address) > 0 && emergencyContactRepository.Update(emergencyContact) > 0)
            {
                MessageBox.Show("Updated succesfully.");
            }
        }

       
        private void btn_Delete(object sender, EventArgs e)
        {
            address = addressRepository.GetByPatientId(patient.Id);
            emergencyContact = emergencyContactRepository.GetByPatientId(patient.Id);

            if (patientRepository.Delete(patient) > 0)
            {
                MessageBox.Show("Deleted Succesfully");
            }

            ClearFields();
            this.Close();
        }

        public void ClearFields()
        {
            txtFirstName.Text = txtLastName.Text = txtGender.Text = txtOccupation.Text = txtBirthDate.Text = txtEmail.Text = txtContactNumber.Text = string.Empty;
            txtCity.Text = txtProvince.Text = txtPostalCode.Text = string.Empty;
            txtEcFirstname.Text = txtECLastName.Text = txtECContactNum.Text = string.Empty;
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnViewConsultations_Click(object sender, EventArgs e)
        {
            new ReadConsultation().Show();
            
        }

        private void btnAddConsultation_Click(object sender, EventArgs e)
        {
            new AddConsultation().Show();
        }
    }
}
