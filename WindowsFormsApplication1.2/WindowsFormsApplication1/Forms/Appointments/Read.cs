using FuaClinic.Business;
using FuaClinic.Business.Managers;
using FuaClinic.Business.Managers.ManagerInterfaces;
using FuaClinic.Business.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApplication1.Utiliies;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;

namespace WindowsFormsApplication1.Forms.Appointments
{
    public partial class Read : Form
    {
        IAppointmentManager appointmentManager;
        ITestResultManager testResultManager;
        IPatientManager patientManager;
        List<TestResult> newtestResults = new List<TestResult>();
        List<TestResult> removedTestResults = new List<TestResult>();
        Patient patient;

        public Read(Patient patient, IPatientManager patientManager, IAppointmentManager appointmentManager, ITestResultManager testResultManager)
        {
            InitializeComponent();
            this.patient = patient;
            this.appointmentManager = appointmentManager;
            this.testResultManager = testResultManager;
            this.patientManager = patientManager;
        }

        private void Add_Load(object sender, EventArgs e)
        {
            txtFirstNameAppointment.Text = patient.FirstName;
            txtLastNameAppointment.Text = patient.LastName;
            txtFirstNameAppointment.ReadOnly = true;
            txtLastNameAppointment.ReadOnly = true;
            FillListViewAppointmentsByPatient();
            btnCancelAppointment.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var appointment = GetSelectedAppointmentFromList();

            if (isValidDateAndTime(appointment))
            {
                UpdateAppointment(appointment);
                InsertTestResultOfAppointment(appointment.Id);
                FillListViewAppointmentsByPatient();
                btnUpdateAppointment.Enabled = false;
            }
            
        }

        private void btnCancelAppointment_Click(object sender, EventArgs e)
        {
            CancelAppointment();
            btnCancelAppointment.Enabled = false;
        }

        private void btnUploadTestResult_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.Filter = "Image Files (*.jpg)|*.jpg|All Files(*.*)|*.*";
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = openFileDialog.FileName;
                var image = Image.FromFile(fileName);
                var name = Path.GetFileName(openFileDialog.FileName);

                var testResult = CreateTestResult(image, name);
                var row = new string[] { testResult.Name };

                var listViewItem = new ListViewItem(row);
                listViewItem.Tag = testResult;
                listViewTestResults.Items.Add(listViewItem);

                newtestResults.Add(testResult);
            }
        }

        private void btnRemoveTestResult_Click(object sender, EventArgs e)
        {
            RemoveTestResultFromListView();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            new Appointments.Add(patient, appointmentManager, testResultManager).Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillListViewAppointmentsByPatient();
            txtDoctorsRemarks.Clear();
            listViewTestResults.Clear();
            newtestResults.Clear();
            removedTestResults.Clear();
            btnUpdateAppointment.Enabled = false;
            btnCancelAppointment.Enabled = false;
        }

        public void RemoveTestResultFromListView()
        {
            if ((listViewTestResults.SelectedItems.Count > 0))
            {
                var testResult = (TestResult)listViewTestResults.SelectedItems[0].Tag;
                removedTestResults.Add(testResult);
                listViewTestResults.SelectedItems[0].Remove();
            }
        }

        public void DeleteTestResults()
        {
            if (removedTestResults.Count > 0)
            {
                var ids = removedTestResults.Select(x => x.Id).ToArray();
                testResultManager.Delete(ids);
                removedTestResults.Clear();
            }
        }

        public void FillListViewAppointmentsByDesiredDate()
        {
            listViewDateTime.Items.Clear();
            AddListViewAppointmentsItems(GetAppointmentsByDesiredDate());
        }

        public IList<Appointment> GetAppointmentsByDesiredDate()
        {
            return appointmentManager.GetWithWhereCondition
                <Appointment>($"cast(DesiredDateTime as date) =" +
                $" '{dateTimePickerAppointment.Value.ToString("yyyy-MM-dd")}' and PatientId = {patient.Id}");
        }


        public void FillListViewAppointmentsByPatient()
        {
            listViewDateTime.Items.Clear();
            AddListViewAppointmentsItems(GetAppointmentByPatientId(patient.Id));
        }

        public IList<Appointment> GetAppointmentByPatientId(int id)
        {
            return appointmentManager.GetWithWhereCondition
                   <Appointment>($"PatientId = '{patient.Id}'");
        }

        public void AddListViewAppointmentsItems(IList<Appointment> appointments)
        {
            foreach (var appointment in appointments)
            {
                var row = new string[]
                {
                    appointment.DesiredDateTime.ToString(),
                };

                var listViewItem = new ListViewItem(row);
                listViewItem.Tag = appointment;
                listViewDateTime.Items.Add(listViewItem);
            }
        }

        private void ListViewDateTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDateTime.SelectedItems.Count > 0)
            {
                var selectedAppointment = GetSelectedAppointmentFromList();
                dateTimePickerAppointment.Value = selectedAppointment.DesiredDateTime;
                txtDoctorsRemarks.Text = selectedAppointment.DoctorsRemarks;

                FillListViewTestResultsByAppointment(selectedAppointment);

                btnUpdateAppointment.Enabled = true;
                btnCancelAppointment.Enabled = true;
            }
        }

        public void FillListViewTestResultsByAppointment(Appointment appointment)
        {
            listViewTestResults.Items.Clear();
            AddListViewTestResultItems(GetTestResultsByAppointmentId(appointment.Id));
        }

        public IList<TestResult> GetTestResultsByAppointmentId(int appointmentId)
        {
            return testResultManager.
                GetWithWhereCondition<TestResult>($"AppointmentId = {appointmentId}");
        }

        public void AddListViewTestResultItems(IList<TestResult> testResults)
        {
            if (testResults != null)
            {
                foreach (var testResult in testResults)
                {
                    var row = new string[] { testResult.Name };
                    var listViewItem = new ListViewItem(row);
                    listViewItem.Tag = testResult;
                    listViewTestResults.Items.Add(listViewItem);
                }
            }
        }

        public void CancelAppointment()
        {
            if (listViewDateTime.SelectedItems.Count > 0)
            {
                var appointment = GetSelectedAppointmentFromList();
                var messageBoxResult = MessageBox.Show("Are you sure you want to cancel appointment?",
                   "Confirm Cancel.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (messageBoxResult == DialogResult.Yes)
                {
                    if (appointmentManager.Delete(new int[] { appointment.Id }))
                    {
                        MessageBox.Show("Appointment cancelled.");
                        FillListViewAppointmentsByPatient();
                    }
                }
            }
        }

        public void UpdateAppointment(Appointment appointment)
        {
            if (listViewDateTime.SelectedItems.Count > 0)
            {
                var messageBoxResult = MessageBox.Show("Are you sure you want to update appointment?",
                   "Confirm Update.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (messageBoxResult == DialogResult.Yes)
                {
                    appointment.DesiredDateTime = dateTimePickerAppointment.Value;
                    appointment.DoctorsRemarks = txtDoctorsRemarks.Text;

                    if (appointmentManager.Update(appointment))
                    {
                        InsertTestResultOfAppointment(appointment.Id);
                        DeleteTestResults();
                        MessageBox.Show("Appointment updated successfully.");
                    }
                }
            }
        }

        public void InsertTestResultOfAppointment(int id)
        {
            if (id > 0 && newtestResults.Count > 0)
            {
                foreach (var testResult in newtestResults)
                {
                    testResult.AppointmentId = id;
                    testResultManager.Add(testResult);
                }

                newtestResults.Clear();
            }
        }

        public Appointment GetSelectedAppointmentFromList()
        {
            return (Appointment)listViewDateTime.SelectedItems[0].Tag;
        }


        public Patient GetPatientById(Appointment appointment)
        {
            return patientManager.GetById<Patient>(appointment.PatientId);
        }

        // TODO: Separate methods for validation, not placed in one method.
        public bool isValidDateAndTime(Appointment appointment)
        {
            var desiredDateAndTime = dateTimePickerAppointment.Value;
            var desiredTime = dateTimePickerAppointment.Value.TimeOfDay;

            if (/*IsPastCurrentDateTime(desiredDateAndTime) ||*/
                IsOutSideClinicShedule(desiredTime) ||
                IsConflicting(desiredDateAndTime, appointment))
            {
                return false;
            }

            return true;
        }

        public bool IsOutSideClinicShedule(TimeSpan time)
        {
            const int OPENING_HOUR_OF_APPOINTMENTS = 8;
            const int CLOSING_HOUR_OF_APPOINTMENTS = 17;
            const int STARTING_HOUR_OF_DRS_ROUNDS = 11;
            const int STARTING_MINUTES_OF_DRS_ROUNDS = 40;
            const int CLOSING_HOUR_OF_DRS_ROUNDS = 15;

            var startOfAppointments = new TimeSpan(OPENING_HOUR_OF_APPOINTMENTS, 0, 0);
            var closingOfAppointments = new TimeSpan(CLOSING_HOUR_OF_APPOINTMENTS, 0, 0);
            var startOfRounds = new TimeSpan(STARTING_HOUR_OF_DRS_ROUNDS, STARTING_MINUTES_OF_DRS_ROUNDS, 0);
            var endOfRounds = new TimeSpan(CLOSING_HOUR_OF_DRS_ROUNDS, 0, 0);

            if (time < startOfAppointments || time > closingOfAppointments ||
                time > startOfRounds && time < endOfRounds)
            {
                ErrorMessages.OutsideOfScheduledTimeOfAppointments();
                return true;
            }

            return false;
        }

        public bool IsConflicting(DateTime dateTime, Appointment selectedAppointment)
        {
            int maxMinutesPerPatient = 20;
            TimeSpan maxMinsPerAppointment = new TimeSpan(0, 0, maxMinutesPerPatient, 0);

            var appointments = appointmentManager.GetAll<Appointment>().ToList();
            appointments.Remove(appointments.Find(x => x.Id == selectedAppointment.Id));
            if (appointments != null)
            {
                foreach (var appointment in appointments)
                {
                    if (dateTime < appointment.DesiredDateTime &&
                        appointment.DesiredDateTime - dateTime < maxMinsPerAppointment ||
                        dateTime > appointment.DesiredDateTime &&
                        dateTime - appointment.DesiredDateTime < maxMinsPerAppointment ||
                        dateTime == appointment.DesiredDateTime
                        )
                    {
                        ErrorMessages.ConflictingWithOtherAppointments();
                        return true;
                    }
                }
            }

            return false;
        }

        // Musangit diri sa pag.update
        public bool IsPastCurrentDateTime(DateTime date)
        {
            var currentDateTime = DateTime.Now;
            if (date < currentDateTime)
            {
                ErrorMessages.HasAlreadyPassed();
                return true;
            }

            return false;
        }


        private void listViewTestResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewTestResults.SelectedItems.Count > 0)
            {
                try
                {
                    var testResult = (TestResult)listViewTestResults.SelectedItems[0].Tag;
                    new Forms.TestResults.Read(testResult, testResultManager).Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dateTimePickerAppointment_KeyUp(object sender, KeyEventArgs e)
        {
            FillListViewAppointmentsByDesiredDate();
        }

        public TestResult CreateTestResult(Image image, string name)
        {
            return new TestResult()
            {
                Name = name,
                Image = ConvertImageToBinary(image)
            };
        }

        public byte[] ConvertImageToBinary(Image image)
        {
            MemoryStream ms = new MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
    }
}





