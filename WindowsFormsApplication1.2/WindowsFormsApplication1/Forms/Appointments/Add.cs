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
    public partial class Add : Form
    {
        IAppointmentManager appointmentManager;
        ITestResultManager testResultManager;
        PatientManager patientManager = new PatientManager();
        Patient patient;

        public Add(Patient patient, IAppointmentManager appointmentManager, ITestResultManager testResultManager)
        {
            InitializeComponent();
            this.patient = patient;
            this.appointmentManager = appointmentManager;
            this.testResultManager = testResultManager;
        }
        private void Add_Load(object sender, EventArgs e)
        {
            txtFirstNameAppointment.Text = patient.FirstName.ToString();
            txtLastNameAppointment.Text = patient.LastName.ToString();
            FillListViewAppointments();
            btnCancelAppointment.Enabled = false;
        }

        private void btnSaveAppointment_Click(object sender, EventArgs e)
        {
            if (isValidDateAndTime())
            {
                AddAppointment(CreateAppointment());
                FillListViewAppointments();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateAppointment();
            FillListViewAppointments();
            btnUpdateAppointment.Enabled = false;
        }

        private void btnCancelAppointment_Click(object sender, EventArgs e)
        {
            CancelAppointment();
            btnCancelAppointment.Enabled = false;

        }

        public void FillListViewAppointments()
        {
            listView1.Items.Clear();
            var appointments = appointmentManager.GetAll<Appointment>();
            foreach (var appointment in appointments)
            {
                var patient = GetPatientById(appointment);
                var row = new string[]
                {
                    patient.FirstName,
                    patient.LastName,
                    appointment.DesiredDateTime.ToString()
                };
                var listViewItem = new ListViewItem(row);
                listViewItem.Tag = appointment;
                listView1.Items.Add(listViewItem);
            }
        }

        public void FillListViewAppointmentsByDesiredDate()
        {
            listView1.Items.Clear();
            var appointments = appointmentManager.GetWithWhereCondition
                <Appointment>($"cast(DesiredDateTime as date) =" +
                $" '{dateTimePickerAppointment.Value.ToString("yyyy-MM-dd")}'");

            foreach (var appointment in appointments)
            {
                var patient = GetPatientById(appointment);
                var row = new string[]
                {
                    patient.FirstName,
                    patient.LastName,
                    appointment.DesiredDateTime.ToString(),
                };
                var listViewItem = new ListViewItem(row);
                listViewItem.Tag = appointment;
                listView1.Items.Add(listViewItem);
            }
        }

        public void FillListViewAppointmentsByPatient()
        {
            listView1.Items.Clear();
            var appointments = appointmentManager.GetWithWhereCondition
                <Appointment>($"PatientId = '{patient.Id}'");
            foreach (var appointment in appointments)
            {
                var patient = GetPatientById(appointment);
                var row = new string[]
                {
                    patient.FirstName,
                    patient.LastName,
                    appointment.DesiredDateTime.ToString(),
                    appointment.DoctorsRemarks
                 };
                var listViewItem = new ListViewItem(row);
                listViewItem.Tag = appointment;
                listView1.Items.Add(listViewItem);
            }
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var selectedAppointment = GetSelectedAppointmentFromList();
                dateTimePickerAppointment.Value = selectedAppointment.DesiredDateTime;
                txtDoctorsRemarks.Text = selectedAppointment.DoctorsRemarks;
                btnUpdateAppointment.Enabled = true;
                btnCancelAppointment.Enabled = true;
                btnSaveAppointment.Enabled = false;

                var patient = patientManager.GetWithWhereCondition
                    <Patient>($"Id = {selectedAppointment.PatientId}").FirstOrDefault();
                txtFirstNameAppointment.Text = patient.FirstName;
                txtLastNameAppointment.Text = patient.LastName;
            }
        }


        public void CancelAppointment()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var appointment = GetSelectedAppointmentFromList();
                var messageBoxResult = MessageBox.Show("Are you sure you want to cancel appointment?",
                   "Confirm Cancel.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (messageBoxResult == DialogResult.Yes)
                {
                    if (appointmentManager.Delete(new int[] { appointment.Id }))
                    {
                        MessageBox.Show("Appointment cancelled.");
                        FillListViewAppointments();
                    }
                }
            }
        }
        public void UpdateAppointment()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var messageBoxResult = MessageBox.Show("Are you sure you want to update appointment?",
                   "Confirm Update.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (messageBoxResult == DialogResult.Yes)
                {
                    var appointment = GetSelectedAppointmentFromList();
                    appointment.DesiredDateTime = dateTimePickerAppointment.Value;
                    appointment.DoctorsRemarks = txtDoctorsRemarks.Text;

                    if (appointmentManager.Update(appointment))
                    {
                        MessageBox.Show("Appointment updated successfully.");
                    }
                    //if (isValidDateAndTime())
                    //{
                    //    var newAppointment = CreateAppointment();
                    //    appointmentManager.Add(newAppointment);
                    //    MessageBox.Show("Appointment updated successfully.");
                    //    FillListViewAppointments();
                    //}
                }
            }
        }

        public Appointment GetSelectedAppointmentFromList()
        {
            return (Appointment)listView1.SelectedItems[0].Tag;

        }
        public void AddAppointment(Appointment appointment)
        {
            if (appointmentManager.Add(appointment) > 0)
            {
                MessageBox.Show("Appointment created successfully.");
            }

        }

        public Patient GetPatientById(Appointment appointment)
        {
            return patientManager.GetById<Patient>(appointment.PatientId);

        }

        public bool isValidDateAndTime()
        {
            //TODO: Improve naming. Use else if statements. Refactor/ improve.
            var desiredDateAndTime = dateTimePickerAppointment.Value;
            var desiredTime = dateTimePickerAppointment.Value.TimeOfDay;

            if (isIdentical(desiredDateAndTime.ToString()) ||
                IsPastCurrentDateTime(desiredDateAndTime) ||
                IsOutSideClinicShedule(desiredTime) ||
                IsConflicting(desiredDateAndTime))
            {
                return false;
            }

            return true;
        }

        public bool isIdentical(string date)
        {
            // TODO: Use GetWithWhereCondition
            var appointments = appointmentManager.GetWithWhereCondition<Appointment>($"DesiredDateTime = '{date}'");

            if (appointments.Count > 0)
            {
                ErrorMessages.IdenticalAppointmentsFound();
                return true;
            }

            return false;
        }

        public bool IsOutSideClinicShedule(TimeSpan time)
        {
            // TODO: Use Constants
            const int STARTINGHOUROFAPPOINTMENTS = 8;
            const int STARTINGMINUNTESOFAPPOINTMENTS = 0;
            const int STARTINGSECONDSOFAPPOINTMENTS = 0;
            const int ENDINGHOUROFAPPOINTMENTS = 17;
            const int ENDINGMINUTESOFAPPOINTMENTS = 0;
            const int ENDINGSECONDSOFAPPOINTMENTS = 0;
            const int STARTINGHOURSOFDRSROUNDS = 11;
            const int STARTINGMINUTESOFDRSROUNDS = 40;
            const int STARTINGSECONDSOFDRSROUNDS = 0;
            const int ENDINGHOURSOFDRSROUNDS = 15;
            const int ENDINGMINUTESOFDRSROUNDS = 0;
            const int ENDINGSECONDSOFDRSROUNDS = 0;

            TimeSpan startOfAppointments = new TimeSpan(STARTINGHOUROFAPPOINTMENTS, STARTINGMINUNTESOFAPPOINTMENTS, STARTINGSECONDSOFAPPOINTMENTS);
            TimeSpan closingOfAppointments = new TimeSpan(ENDINGHOUROFAPPOINTMENTS, ENDINGMINUTESOFAPPOINTMENTS, ENDINGSECONDSOFAPPOINTMENTS);
            TimeSpan startOfRounds = new TimeSpan(STARTINGHOURSOFDRSROUNDS, STARTINGMINUTESOFDRSROUNDS, STARTINGSECONDSOFDRSROUNDS);
            TimeSpan endOfRounds = new TimeSpan(ENDINGHOURSOFDRSROUNDS, ENDINGMINUTESOFDRSROUNDS, ENDINGSECONDSOFDRSROUNDS);

            if (time < startOfAppointments || time > closingOfAppointments ||
                time > startOfRounds && time < endOfRounds)
            {
                ErrorMessages.OutsideOfScheduledTimeOfAppointments();
                return true;
            }

            return false;
        }

        public bool IsConflicting(DateTime dateTime)
        {
            int maxMinutesPerPatient = 20;
            TimeSpan maxMinsPerAppointment = new TimeSpan(0, 0, maxMinutesPerPatient, 0);

            var appointments = appointmentManager.GetAll<Appointment>();
            if (appointments != null)
            {
                foreach (var appointment in appointments)
                {
                    if (dateTime < appointment.DesiredDateTime &&
                        appointment.DesiredDateTime - dateTime < maxMinsPerAppointment ||
                        dateTime > appointment.DesiredDateTime &&
                        dateTime - appointment.DesiredDateTime < maxMinsPerAppointment
                        )
                    {
                        ErrorMessages.ConflictingWithOtherAppointments();
                        return true;
                    }
                }
            }

            return false;
        }

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


        public Appointment CreateAppointment()
        {
            var appointment = new Appointment();
            appointment.PatientId = patient.Id;
            appointment.DesiredDateTime = dateTimePickerAppointment.Value;
            appointment.DoctorsRemarks = txtDoctorsRemarks.Text;
            return appointment;
        }


        private void RadioAtDesiredDate_CheckedChanged(object sender, EventArgs e)
        {
            FillListViewAppointmentsByDesiredDate();
        }

        private void RadioAtPatientsAppointment_CheckedChanged(object sender, EventArgs e)
        {
            FillListViewAppointmentsByPatient();
            txtFirstNameAppointment.Text = patient.FirstName;
            txtLastNameAppointment.Text = patient.LastName;
        }

        private void RadioAll_CheckedChanged(object sender, EventArgs e)
        {
            FillListViewAppointments();
        }

        private void BtnTestResults_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var appointment = GetSelectedAppointmentFromList();
                new TestResults.TestResults(appointment).Show();
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            btnUpdateAppointment.Enabled = false;
            btnCancelAppointment.Enabled = false;
            btnSaveAppointment.Enabled = true;


        }

        private void txtDoctorsRemarks_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerAppointment_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblDateAppointment_Click(object sender, EventArgs e)
        {

        }

        private void txtLastNameAppointment_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLastNameAppointment_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstNameAppointment_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFirstNameAppointment_Click(object sender, EventArgs e)
        {

        }
    }
}





