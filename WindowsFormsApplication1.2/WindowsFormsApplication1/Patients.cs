using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dapper;
using FuaClinic.Business.Repositories;
using FuaClinic.Business;

namespace FuaClinic
{
    public partial class Patients : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source = DESKTOP-PN05J6C\SQLEXPRESS;Initial Catalog= FuaClinic;Integrated Security =True;");
        AddressRepository addressRepository = new AddressRepository();
        EmergencyContactRepository emergencyContactRepository = new EmergencyContactRepository();
        PatientRepository patientRepository = new PatientRepository();
        int patientId = 0;

        public Patients()
        {
            InitializeComponent();
        }

        private void SavePatient(object sender, EventArgs e)
        {
            if (btnSave.Text == "Edit")
            {
                var existingPatient = patientRepository.GetById(patientId);
                existingPatient.LastName = txtLastName.Text;
                existingPatient.FirstName = txtFistName.Text;
                existingPatient.Gender = txtGender.Text;
                existingPatient.BirthDate = txtBirthDate.Text;
                existingPatient.Occupation = txtOccupation.Text;
                existingPatient.Email = txtEmail.Text;
                existingPatient.ContactNumber = txtContactNumber.Text;

                if (patientRepository.Update(existingPatient) > 0)
                {
                    MessageBox.Show("Updated successfully");
                }
            }
            else
            {
                var patient = new Patient();
                patient.LastName = txtLastName.Text;
                patient.FirstName = txtFistName.Text;
                patient.Gender = txtGender.Text;
                patient.BirthDate = txtBirthDate.Text;
                patient.Occupation = txtOccupation.Text;
                patient.Email = txtEmail.Text;
                patient.ContactNumber = txtContactNumber.Text;

                if (patientRepository.Add(patient) > 0)
                {
                    MessageBox.Show("Saved succesfully");
                }
            }

            FillDataGridView();
        }

        private void SaveAddress(object sender, EventArgs e)
        {
            if (btnSaveAddress.Text == "Edit")
            {
                var existingAddress = addressRepository.GetByPatientId(patientId);
                existingAddress.PatientId = Convert.ToInt32(txtPatientIdAddress.Text);
                existingAddress.City = txtCity.Text;
                existingAddress.Province = txtProvince.Text;
                existingAddress.PostalCode = txtPostalCode.Text;
                if (addressRepository.Update(existingAddress) > 0)
                {
                    MessageBox.Show("Updated Successfully");
                }

            }
            else
            {
                var address = new Address();
                address.PatientId = Convert.ToInt32(txtPatientIdAddress.Text);
                address.City = txtCity.Text;
                address.Province = txtProvince.Text;
                address.PostalCode = txtPostalCode.Text;
                if (addressRepository.Add(address) > 0)
                {
                    MessageBox.Show("Saved Successfully.");
                }

            }
            FillDataGridView();
        }

        private void SaveEmergencyContact(object sender, EventArgs e)
        {
            if (btnDeleteEmergencyContact.Text == "Edit")
            {
                var exisitngEmergencyContact = emergencyContactRepository.GetByPatientId(patientId);
                exisitngEmergencyContact.PatientId = Convert.ToInt32(txtPatientIdEmergencyContact.Text);
                exisitngEmergencyContact.FirstName = txtEcFirstname.Text;
                exisitngEmergencyContact.LastName = txtECLastName.Text;
                exisitngEmergencyContact.ContactNumber = txtECContactNumber.Text;
                if (emergencyContactRepository.Update(exisitngEmergencyContact) > 0)
                {
                    MessageBox.Show("Updated Successfully");
                }

            }
            else
            {
                var emergencyContact = new EmergencyContact();
                emergencyContact.PatientId = Convert.ToInt32(txtPatientIdEmergencyContact.Text);
                emergencyContact.FirstName = txtEcFirstname.Text;
                emergencyContact.LastName = txtECLastName.Text;
                emergencyContact.ContactNumber = txtECContactNumber.Text;
                if (emergencyContactRepository.Add(emergencyContact) > 0)
                {
                    MessageBox.Show("Saved Successfully.");
                }
            }

            FillDataGridView();



        }


        private void DeletePatient(object sender, EventArgs e)
        {

            var patient = patientRepository.GetById(patientId);
            if (patientRepository.Delete(patient) > 0)
            {
                MessageBox.Show("Deleted Succesfully");
            }
            ClearPatientFields();
            FillDataGridView();

        }

        private void ClearPatientButton(object sender, EventArgs e)
        {
            ClearPatientFields();
        }

        public void ClearPatientFields()
        {
            txtFistName.Text = txtLastName.Text = txtGender.Text = txtOccupation.Text = txtBirthDate.Text = txtEmail.Text = txtContactNumber.Text = string.Empty;

            btnSave.Text = "Save";
            btnDelete.Enabled = false;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtECBirthDate_TextChanged(object sender, EventArgs e)
        {

        }


        public void FillDataGridView()
        {

            if (sqlConnection.State == ConnectionState.Closed)
                sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("ViewPatients", sqlConnection);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
           
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@LastName", txtSearchLastName.Text.Trim());
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@FirstName", txtSearchFirstName.Text.Trim());
           

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridPatients.DataSource = dataTable;

            dataGridPatients.Columns[3].Visible = false;
            dataGridPatients.Columns[4].Visible = false;
            dataGridPatients.Columns[5].Visible = false;
            dataGridPatients.Columns[6].Visible = false;
            dataGridPatients.Columns[7].Visible = false;

            sqlConnection.Close();
        }


        private void SearchList(object sender, EventArgs e)
        {
            try
            {
                FillDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Patients_Load(object sender, EventArgs e)
        {
            FillDataGridView();
            btnDelete.Enabled = false;
            btnDeleteAddress.Enabled = false;
            btnDeleteEmergencyContact.Enabled = false;
            txtSearchFirstName.Visible = false;
            txtSearchLastName.Visible = false;
            advanceSearchFirstName.Visible = false;
            advanceSearchLastName.Visible = false;
            

        }

        private void txtSearchText_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridPatients_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dataGridPatients.CurrentRow.Index != -1)
                {
                    patientId = Convert.ToInt32(dataGridPatients.CurrentRow.Cells[0].Value.ToString());
                    txtLastName.Text = dataGridPatients.CurrentRow.Cells[1].Value.ToString();
                    txtFistName.Text = dataGridPatients.CurrentRow.Cells[2].Value.ToString();
                    txtGender.Text = dataGridPatients.CurrentRow.Cells[3].Value.ToString();
                    txtBirthDate.Text = dataGridPatients.CurrentRow.Cells[4].Value.ToString();
                    txtContactNumber.Text = dataGridPatients.CurrentRow.Cells[5].Value.ToString();
                    txtEmail.Text = dataGridPatients.CurrentRow.Cells[6].Value.ToString();
                    txtOccupation.Text = dataGridPatients.CurrentRow.Cells[7].Value.ToString();

                    var address = addressRepository.GetByPatientId(patientId);
                    if (address != null)
                    {
                        txtPatientIdAddress.Text = address.PatientId.ToString();
                        txtCity.Text = address.City;
                        txtProvince.Text = address.Province;
                        txtPostalCode.Text = address.PostalCode;
                    }
                    else
                    {
                        txtPatientIdAddress.Text = txtCity.Text = txtProvince.Text = txtPostalCode.Text = string.Empty;
                    }

                    var emergencyContact = emergencyContactRepository.GetByPatientId(patientId);
                    if (emergencyContact != null)
                    {
                        txtPatientIdEmergencyContact.Text = emergencyContact.PatientId.ToString();
                        txtEcFirstname.Text = emergencyContact.FirstName;
                        txtECLastName.Text = emergencyContact.LastName;
                        txtECContactNumber.Text = emergencyContact.ContactNumber;
                    }
                    else
                    {
                        txtPatientIdEmergencyContact.Text = txtEcFirstname.Text = txtECLastName.Text = txtECContactNumber.Text = string.Empty;
                    }


                    btnSave.Text = "Edit";
                    btnSaveAddress.Text = "Edit";
                    btnSaveEmergencyContact.Text = "Edit";
                    btnDelete.Enabled = true;
                    btnDeleteAddress.Enabled = true;
                    btnDeleteEmergencyContact.Enabled = true;





                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

       

        private void ClearAddressButton(object sender, EventArgs e)
        {
            ClearAddressFields();

        }
        public void ClearAddressFields()
        {
            txtPatientIdAddress.Text = txtCity.Text = txtProvince.Text = txtPostalCode.Text = string.Empty;
            btnSaveAddress.Text = "Save";
            btnDeleteAddress.Enabled = false;
        }

        private void ClearEmergencyContactButton(object sender, EventArgs e)
        {
            ClearEmergencyContactFields();
        }
        public void ClearEmergencyContactFields()
        {
            txtPatientIdEmergencyContact.Text = txtEcFirstname.Text = txtECLastName.Text = txtECContactNumber.Text = string.Empty;
            btnSaveEmergencyContact.Text = "Save";
            btnDeleteEmergencyContact.Enabled = false;
        }


        private void DeleteAddress(object sender, EventArgs e)
        {
            var address = addressRepository.GetByPatientId(patientId);
            if (addressRepository.Delete(address) > 0)
            {
                MessageBox.Show("Deleted Successfully");
            }
            ClearAddressFields();
            FillDataGridView();
        }

        private void DeleteEmergencyContact(object sender, EventArgs e)
        {
            var emergencyContact = emergencyContactRepository.GetByPatientId(patientId);
            if (emergencyContactRepository.Delete(emergencyContact) > 0)
            {
                MessageBox.Show("Deleted Successfully");
            }
            ClearEmergencyContactFields();
            FillDataGridView();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void AdvanceSearch(object sender, EventArgs e)
        {
            txtSearchFirstName.Visible = true;
            txtSearchLastName.Visible = true;
            advanceSearchFirstName.Visible = true;
            advanceSearchLastName.Visible = true;

            try
            {
                FillDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
  
      

        
    }
}
