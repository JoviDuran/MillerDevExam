using FuaClinic.Business;
using FuaClinic.Business.Managers;
using FuaClinic.Business.Managers.ManagerInterfaces;
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
        IAppointmentManager appointmentManager;
        ITestResultManager testResultManager;
        Patient patient;
        List<TestResult> testResults = new List<TestResult>();

        public Add(
            Patient patient,
            IAppointmentManager appointmentManager,
            ITestResultManager testResultManager)
        {
            InitializeComponent();
            this.patient = patient;
            this.appointmentManager = appointmentManager;
            this.testResultManager = testResultManager;
        }

        private void Add_Load(object sender, EventArgs e)
        {
            FillListViewAppointments();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isValidDateAndTime())
            {
                SaveTestResults(SaveAppointment(CreateAppointment()));
                MessageBox.Show("Appointment created successfully");
                this.Close();
            }
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

                testResults.Add(CreateTestResult(image, name));
                FillListViewTestResults();
            }
        }

        public void FillListViewAppointments()
        {
            listViewAppointments.Items.Clear();
            AddListViewAppointmentsItems(GetAllAppointments());
        }
        public void FillListViewAppointmentsByDesiredDate()
        {
            listViewAppointments.Items.Clear();
            AddListViewAppointmentsItems(GetAppointmentsByDate());
        }

        public void AddListViewAppointmentsItems(IList<Appointment> appointments)
        {
            foreach (var appointment in appointments)
            {
                var row = new string[] { appointment.DesiredDateTime.ToString() };
                var listViewItem = new ListViewItem(row);
                listViewItem.Tag = appointment;
                listViewAppointments.Items.Add(listViewItem);
            }
        }

        public IList<Appointment> GetAllAppointments()
        {
            return appointmentManager.GetAll<Appointment>();
        }
        public IList<Appointment> GetAppointmentsByDate()
        {
            return appointmentManager.GetWithWhereCondition
                <Appointment>($"cast(DesiredDateTime as date) =" +
                $" '{dateTimePickerAppointment.Value.ToString("yyyy-MM-dd")}'");
        }

        

        public bool isValidDateAndTime()
        {
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

            var startOfAppointments = new TimeSpan(STARTINGHOUROFAPPOINTMENTS, STARTINGMINUNTESOFAPPOINTMENTS, STARTINGSECONDSOFAPPOINTMENTS);
            var closingOfAppointments = new TimeSpan(ENDINGHOUROFAPPOINTMENTS, ENDINGMINUTESOFAPPOINTMENTS, ENDINGSECONDSOFAPPOINTMENTS);
            var startOfRounds = new TimeSpan(STARTINGHOURSOFDRSROUNDS, STARTINGMINUTESOFDRSROUNDS, STARTINGSECONDSOFDRSROUNDS);
            var endOfRounds = new TimeSpan(ENDINGHOURSOFDRSROUNDS, ENDINGMINUTESOFDRSROUNDS, ENDINGSECONDSOFDRSROUNDS);

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
            var maxMinutesPerPatient = 20;
            var maxMinsPerAppointment = new TimeSpan(0, 0, maxMinutesPerPatient, 0);

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

        public int SaveAppointment(Appointment appointment)
        {
            return appointmentManager.Add(appointment);
        }

        private void dateTimePickerAppointment_KeyUp(object sender, KeyEventArgs e)
        {
            FillListViewAppointmentsByDesiredDate();
        }

        public TestResult CreateTestResult(Image image, string fileName)
        {
            return new TestResult()
            {
                Name = fileName,
                Image = ConvertImageToBinary(image)
            };
        }

        public void SaveTestResults(int appointmentId)
        {
            if (appointmentId > 0)
            {
                foreach (var testResult in testResults)
                {
                    testResult.AppointmentId = appointmentId;
                    testResultManager.Add(testResult);
                }

                testResults.Clear();
            }
        }

        public byte[] ConvertImageToBinary(Image image)
        {
            MemoryStream memoryStream = new MemoryStream();
            image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            return memoryStream.ToArray();
        }

        public void FillListViewTestResults()
        {
            listViewTestResults.Items.Clear();
            AddListViewTestResultItems(testResults);
           
        }

        public void AddListViewTestResultItems(List<TestResult> testResults)
        {
            if (testResults !=null)
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
    }
}
