using FuaClinic.Business;
using FuaClinic.Business.Managers;
using FuaClinic.Business.Managers.ManagerInterfaces;
using FuaClinic.Business.Models;
using System;
using System.Windows.Forms;
using WindowsFormsApplication1.Utiliies;

namespace WindowsFormsApplication1.Forms.Appointments
{
    public partial class Add : Form
    {
        IAppointmentManager appointmentManager;
        Patient patient;

        public Add(Patient patient, IAppointmentManager appointmentManager)
        {
            InitializeComponent();
            this.patient = patient;
            this.appointmentManager = appointmentManager;
        }
        private void Add_Load(object sender, EventArgs e)
        {
            txtFirstNameAppointment.Text = patient.FirstName.ToString();
            txtLastNameAppointment.Text = patient.LastName.ToString();
            FillDataGridViewAppointments();

        }

        private void dateTimePickerAppointment_ValueChanged(object sender, EventArgs e)
        {
            FillAppointmentsTableByDate();
        }

        private void dateTimePickerAppointment_KeyUp(object sender, KeyEventArgs e)
        {
            FillAppointmentsTableByDate();
        }
        private void btnPatientsAppointments_Click(object sender, EventArgs e)
        {
            FillAppointmentsTableByPatientId();
        }

        private void btnSaveAppointment_Click(object sender, EventArgs e)
        {
            if (isValidDateAndTime())
            {
                AddAppointment(CreateAppointment());
                FillDataGridViewAppointments();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FillDataGridViewAppointments();
        }

        public void AddAppointment(Appointment appointment)
        {
            if (appointmentManager.Add(appointment) > 0)
            {
                MessageBox.Show("Appointment created successfully.");
            }
        }

        public bool isValidDateAndTime()
        {
            //TODO: Improve naming. Use else if statements. Refactor/ improve.
            var desiredDateAndTime = dateTimePickerAppointment.Value;
            var desiredTime = dateTimePickerAppointment.Value.TimeOfDay;

            if (isIdentical(desiredDateAndTime.ToString()) ||
                IsPastCurrentDateTime(desiredDateAndTime) ||
                IsNotInClinicShedule(desiredTime) ||
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

        public bool IsNotInClinicShedule(TimeSpan time)
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
            return appointment;
        }

        public void FillDataGridViewAppointments()
        {
            dataGridViewAppointments.DataSource = appointmentManager.GetAll();
            ShowImportantColumnsofDataGridViewAppointments();
        }

        public void FillAppointmentsTableByDate()
        {
            dataGridViewAppointments.DataSource = appointmentManager.GetByDate
                (dateTimePickerAppointment.Value.ToString("yyyy-MM-dd"));
            ShowImportantColumnsofDataGridViewAppointments();
        }

        public void FillAppointmentsTableByPatientId()
        {
            dataGridViewAppointments.DataSource = appointmentManager.GetByPatientId(patient.Id);
            ShowImportantColumnsofDataGridViewAppointments();

        }
        public void ShowImportantColumnsofDataGridViewAppointments()
        {
            dataGridViewAppointments.Columns[0].Visible = false;
            dataGridViewAppointments.Columns[1].Visible = false;
        }
    }
}





