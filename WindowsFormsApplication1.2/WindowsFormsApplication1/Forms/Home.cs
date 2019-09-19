using System;
using System.Windows.Forms;
using Dapper;
using FuaClinic.Business;
using WindowsFormsApplication1;
using FuaClinic.Business.Managers;
using System.Collections.Generic;
using FuaClinic.Business.Models;
using System.Linq;

namespace FuaClinic
{
    public partial class Home : Form
    {
        PatientManager patientManager = new PatientManager();
        AddressManager addressManager = new AddressManager();
        EmergencyContactManager emergencyContactManager = new EmergencyContactManager();
        AppointmentManager appointmentManager = new AppointmentManager();
        ConsultationManager consultationManager = new ConsultationManager();
        PatientArchiveManager patientArchiveManager = new PatientArchiveManager();
        TestResultManager testResultManager = new TestResultManager();


        public Home()
        {
            InitializeComponent();
        }

        private void LoadForm(object sender, EventArgs e)
        {
            FillDataGridViewPatients();
            FillDataGridViewAppointments();
            FillDataGridViewConsultations();
            FillDataGridViewPatientArchive();
            ShowImportantColumnsOfDataGridViewConsultations();
            ShowImportanColumnsOfDataGridViewPatients();
            ShowImportantColumnsofDataGridViewAppointments();
            //ShowImportanColumnsOfDataGridViewPatientArchive();
        }

        // Patient UI
        private void AddPatient_Click(object sender, EventArgs e)
        {

            new Add(patientManager, emergencyContactManager, consultationManager, addressManager).Show();
        }
        private void SearchPatient_Click(object sender, EventArgs e)
        {
            FillDataGridViewPatientsThroughSearch();
        }
        private void DeletePatient_Click(object sender, EventArgs e)
        {
            DeletePatient();
        }

        private void ViewPatientInfo_Click(object sender, EventArgs e)
        {
            var patient = GetPatientDetails();
            new Read(patient, patientManager, addressManager, emergencyContactManager, testResultManager).Show();
        }

        private void ViewConsultations(object sender, EventArgs e)
        {
            var patientId = Convert.ToInt32(dataGridViewConsultations.CurrentRow.Cells[1].Value.ToString());
            var patient = GetPatientById(patientId);
            new WindowsFormsApplication1.Forms.Consultations.Read(patient, consultationManager).Show();
        }

        private void RefreshDataGridViewPatients_Click(object sender, EventArgs e)
        {
            FillDataGridViewPatients();
            ShowImportanColumnsOfDataGridViewPatients();
            textSearchFirstName.Text = txtSearchLastName.Text = string.Empty;
            radioFemale.Checked = false;
            radioMale.Checked = false;
        }

        // Consultations UI
        private void dateTimePickerConsultations_keyUp(object sender, KeyEventArgs e)
        {
            GetConsultationsByDate();
            ShowImportantColumnsOfDataGridViewConsultations();
        }

        private void dateOfConsultationPicker_ValueChanged(object sender, EventArgs e)
        {
            GetConsultationsByDate();
            ShowImportantColumnsOfDataGridViewConsultations();
        }

        private void RefreshDataGridViewConsultations_Click(object sender, EventArgs e)
        {
            FillDataGridViewConsultations();
            ShowImportantColumnsOfDataGridViewConsultations();
        }

        // Appointments UI
        private void BtnRefreshDataGridViewAppointments_Click(object sender, EventArgs e)
        {
            FillDataGridViewAppointments();
            ShowImportantColumnsofDataGridViewAppointments();
        }

        private void BtnDeleteAppointment_Click(object sender, EventArgs e)
        {
            DeleteAppointment();
        }

        private void dateTimePickerAppointment_KeyUp(object sender, KeyEventArgs e)
        {
            FillAppointmentsTableByDate();
        }

        private void dateTimePickerAppointment_ValueChanged(object sender, EventArgs e)
        {
            FillAppointmentsTableByDate();
        }

        private void ViewAppointments(object sender, EventArgs e)
        {
            var patient = GetPatientById(Convert.ToInt32(dataGridViewAppointments.CurrentRow.Cells[1].Value.ToString()));
            new WindowsFormsApplication1.Forms.Appointments.Read(patient, patientManager, appointmentManager, testResultManager).Show();
        }

        // Patient Archive UI
        private void btnSearchPatientArchive_Click(object sender, EventArgs e)
        {
            FillDateGridViewPatientArchiveThroughSearch();
        }

        public void ShowImportanColumnsOfDataGridViewPatients()
        {
            dataGridViewPatients.Columns[0].Visible = false;
            dataGridViewPatients.Columns[4].Visible = false;
            dataGridViewPatients.Columns[5].Visible = false;
            dataGridViewPatients.Columns[6].Visible = false;
            dataGridViewPatients.Columns[7].Visible = false;
        }
        private void btnRefreshPatientArchive_Click(object sender, EventArgs e)
        {
            FillDataGridViewPatientArchive();
        }


        // Other methods
        public void ShowImportantColumnsOfDataGridViewConsultations()
        {
            dataGridViewConsultations.Columns[0].Visible = false;
            dataGridViewConsultations.Columns[1].Visible = false;
        }

        public void ShowImportantColumnsofDataGridViewAppointments()
        {
            dataGridViewAppointments.Columns[0].Visible = false;
            dataGridViewAppointments.Columns[1].Visible = false;

        }

        public void ShowImportanColumnsOfDataGridViewPatientArchive()
        {
            dataGridViewPArchive.Columns[0].Visible = false;
            dataGridViewPArchive.Columns[4].Visible = false;
            dataGridViewPArchive.Columns[5].Visible = false;
            dataGridViewPArchive.Columns[6].Visible = false;
            dataGridViewPArchive.Columns[7].Visible = false;
        }



        public void DeletePatient()
        {
            if (dataGridViewPatients.SelectedRows.Count > 0)
            {
                var ids = new List<int>();

                foreach (DataGridViewRow row in dataGridViewPatients.SelectedRows)
                {
                    ids.Add(Convert.ToInt32(row.Cells[0].Value));
                }   

                var messageBoxResult = MessageBox.Show("Are you sure you want to delete?",
                    "Confirm Delete.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (messageBoxResult == DialogResult.Yes)
                {
                    foreach (var id in ids)
                    {
                        var patient = patientManager.GetById<Patient>(id);
                        var address = addressManager.GetWithWhereCondition<Address>($"PatientId = {id}").FirstOrDefault();
                        var emergencyContact = emergencyContactManager.GetWithWhereCondition<EmergencyContact>($"PatientId = {id}").FirstOrDefault();
                        var patientArchive = new PatientArchive();
                        patientArchive.FirstName = patient.FirstName;
                        patientArchive.LastName = patient.LastName;
                        patientArchive.Gender = patient.Gender;
                        patientArchive.BirthDate = patient.BirthDate;
                        patientArchive.ContactNumber = patient.ContactNumber;
                        patientArchive.Email = patient.Email;
                        patientArchive.Occupation = patient.Occupation;
                        patientArchive.Address = $"{address.City}, {address.Province}, {address.PostalCode}";
                        patientArchive.EmergencyContact = $"{emergencyContact.FirstName}, {emergencyContact.LastName}, {emergencyContact.ContactNumber}"; 
                        patientArchiveManager.Add(patientArchive);
                    }

                    if (patientManager.Delete(ids.ToArray()))
                    {
                        MessageBox.Show("Deleted Succesfully");
                        FillDataGridViewPatients();
                        FillDataGridViewPatientArchive();
                    }
                }
            }
        }

        public void DeleteAppointment()
        {
            if (dataGridViewAppointments.SelectedRows.Count > 0)
            {
                var ids = new List<int>();
                foreach (DataGridViewRow row in dataGridViewAppointments.SelectedRows)
                {
                    ids.Add(Convert.ToInt32(row.Cells[0].Value));
                }
                var messageBoxResult = MessageBox.Show("Are you sure you want to delete?",
                    "Confirm Delete.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (messageBoxResult == DialogResult.Yes)
                {
                    if (appointmentManager.Delete(ids.ToArray()))
                    {
                        MessageBox.Show("Deleted Succesfully");
                        FillDataGridViewAppointments();
                    }
                }
            }
        }


        public Patient GetPatientById(int id)
        {
            return patientManager.GetById<Patient>(id);
        }




        public void FillDateGridViewPatientArchiveThroughSearch()
        {
            var parameter = new DynamicParameters();
            parameter.Add("@SearchFirstName", txtSearchFirstNamePA.Text.Trim());
            parameter.Add("@SearchLastName", txtSearchLastNamePA.Text.Trim());
            dataGridViewPArchive.DataSource = patientArchiveManager.GetBySearch(parameter);
        }

        public Patient GetPatientDetails()
        {
            var patient = new Patient();
            patient.Id = Convert.ToInt32(dataGridViewPatients.CurrentRow.Cells[0].Value.ToString());
            patient.FirstName = dataGridViewPatients.CurrentRow.Cells[1].Value.ToString();
            patient.LastName = dataGridViewPatients.CurrentRow.Cells[2].Value.ToString();
            patient.Gender = dataGridViewPatients.CurrentRow.Cells[3].Value.ToString();
            patient.BirthDate = Convert.ToDateTime(dataGridViewPatients.CurrentRow.Cells[4].Value);
            patient.Email = dataGridViewPatients.CurrentRow.Cells[5].Value.ToString();
            patient.Occupation = dataGridViewPatients.CurrentRow.Cells[6].Value.ToString();
            patient.ContactNumber = dataGridViewPatients.CurrentRow.Cells[7].Value.ToString();
            return patient;
        }
        public void FillDataGridViewPatientsThroughSearch()
        {
            var gender = string.Empty;
            var parameter = new DynamicParameters();
            parameter.Add("@SearchFirstName", textSearchFirstName.Text.Trim());
            parameter.Add("@SearchLastName", txtSearchLastName.Text.Trim());
            if (radioFemale.Checked)
            {
                gender = "F";
            }
            else if (radioMale.Checked)
            {
                gender = "M";
            }
            else
            {
                gender = string.Empty;
            }
            parameter.Add("@SearchGender", gender);
            dataGridViewPatients.DataSource = patientManager.GetBySearch(parameter);
            ShowImportanColumnsOfDataGridViewPatients();
        }

        public void GetConsultationsByDate()
        {
            var parameter = new DynamicParameters();
            parameter.Add("@SearchText", dateOfConsultationPicker.Text.Trim());
            dataGridViewConsultations.DataSource = consultationManager.GetByDate(parameter);
        }

        public void FillDataGridViewConsultations()
        {
            dataGridViewConsultations.DataSource = consultationManager.GetAll();
        }

        public void FillDataGridViewAppointments()
        {
            dataGridViewAppointments.DataSource = appointmentManager.GetAll();
        }

        public void FillDataGridViewPatientArchive()
        {
            dataGridViewPArchive.DataSource = patientArchiveManager.GetAll();
        }
        public void FillDataGridViewPatients()
        {
            dataGridViewPatients.DataSource = patientManager.GetAll();
        }

        public void FillAppointmentsTableByDate()
        {
            dataGridViewAppointments.DataSource = appointmentManager.GetByDate(dateTimePickerAppointment.Value.ToString("yyyy-MM-dd"));
            ShowImportantColumnsofDataGridViewAppointments();
        }
    }
}