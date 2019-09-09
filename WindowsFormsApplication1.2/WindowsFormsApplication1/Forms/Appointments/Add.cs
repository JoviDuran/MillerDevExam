﻿using FuaClinic.Business;
using FuaClinic.Business.Managers;
using FuaClinic.Business.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WindowsFormsApplication1.Utiliies;

namespace WindowsFormsApplication1.Forms.Appointments
{
    public partial class Add : Form
    {
        AppointmentManager appointmentManager = new AppointmentManager();
        PatientManager patientManager = new PatientManager();
        TestResultManager testResultManager = new TestResultManager();
        Patient patient;
        List<TestResult> testResults = new List<TestResult>();
        public Add(Patient patient)
        {
            InitializeComponent();
            this.patient = patient;
        }

        private void Add_Load(object sender, EventArgs e)
        {
            FillListViewAppointments();
        }

        public void FillListViewAppointments()
        {
            listViewAppointments.Items.Clear();
            var appointments = appointmentManager.GetAll<Appointment>();
            foreach (var appointment in appointments)
            {
                var row = new string[]
                {
                    appointment.DesiredDateTime.ToString()
                };
                var listViewItem = new ListViewItem(row);
                listViewItem.Tag = appointment;
                listViewAppointments.Items.Add(listViewItem);
            }
        }

        public void FillListViewAppointmentsByDesiredDate()
        {
            listViewAppointments.Items.Clear();
            var appointments = appointmentManager.GetWithWhereCondition
                <Appointment>($"cast(DesiredDateTime as date) =" +
                $" '{dateTimePickerAppointment.Value.ToString("yyyy-MM-dd")}'");

            foreach (var appointment in appointments)
            {
                var row = new string[]
                {
                    appointment.DesiredDateTime.ToString()
                };
                var listViewItem = new ListViewItem(row);
                listViewItem.Tag = appointment;
                listViewAppointments.Items.Add(listViewItem);
            }
        }

        public bool isValidDateAndTime()
        {
            //TODO: Improve naming. Use else if statements. Refactor/ improve.
            var desiredDateAndTime = dateTimePickerAppointment.Value;
            var desiredTime = dateTimePickerAppointment.Value.TimeOfDay;

            if (IsPastCurrentDateTime(desiredDateAndTime) ||
                IsOutSideClinicShedule(desiredTime) ||
                IsConflicting(desiredDateAndTime))
            {
                return false;
            }

            return true;
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
            return new Appointment()
            {
                PatientId = patient.Id,
                DesiredDateTime = dateTimePickerAppointment.Value,
                DoctorsRemarks = txtDoctorsRemarks.Text
            };
        }

        //public Patient GetPatientById(Appointment appointment)
        //{
        //    return patientManager.GetById<Patient>(appointment.PatientId);
        //}


        private void dateTimePickerAppointment_KeyUp(object sender, KeyEventArgs e)
        {
            FillListViewAppointmentsByDesiredDate();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isValidDateAndTime())
            {
                var appointmentId = SaveAppointment(CreateAppointment());
                SaveTestResults(appointmentId);
                MessageBox.Show("Appointment created successfully");
            }
        }

        public int SaveAppointment(Appointment appointment)
        {
            return appointmentManager.Add(appointment);
        }

        public void SaveTestResults(int id)
        {
            if (id > 0)
            {
                foreach (var testResult in testResults)
                {
                    testResult.AppointmentId = id;
                    testResultManager.Add(testResult);
                }
            }
           
        }


        //public void AddAppointment(Appointment appointment)
        //{
        //    if (appointmentManager.Add(appointment) > 0)
        //    {
        //        MessageBox.Show("Appointment created successfully.");
        //    }
        //}

        public TestResult CreateTestResult(Image image, string fileName)
        {
            return new TestResult()
            {
                Name = fileName,
                Image = ConvertImageToBinary(image)
            };
        }

        public byte[] ConvertImageToBinary(Image image)
        {
            MemoryStream ms = new MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
       

        private void btnAddTestResult_Click(object sender, EventArgs e)
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

                testResults.Add(testResult);
                FillListViewTestResults();
            }
        }

        public void FillListViewTestResults()
        {
            listViewTestResults.Items.Clear();
            foreach (var testResult in testResults)
            {
                var row = new string[] { testResult.Name };
                var listViewItem = new ListViewItem(row);
                listViewItem.Tag = testResult;
                listViewTestResults.Items.Add(listViewItem);
            }

        }
    }
}
