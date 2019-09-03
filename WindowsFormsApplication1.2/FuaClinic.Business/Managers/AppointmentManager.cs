using FuaClinic.Business.Managers.ManagerInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuaClinic.Business.Repositories.Interfaces;
using FuaClinic.Business.Repositories;
using Dapper;
using System.Data;
using FuaClinic.Business.Models;

namespace FuaClinic.Business.Managers
{
    public class AppointmentManager : BaseManager, IAppointmentManager
    {
        internal override IRepository Repository => new AppointmentRepository();
        PatientManager patientManager = new PatientManager();

        public DataTable GetAll()
        {
            var appointments = Repository.SelectAll<Appointment>().ToList();
            return CreateDataTable(appointments);
        }

        public DataTable GetByDate(string date)
        {
            var appointments = (Repository as IAppointmentRepository).SelectWithWhereCondition<Appointment>($"cast(DesiredDateTime as date) = '{date}'").ToList();
            return CreateDataTable(appointments);
        }

        public DataTable GetByTime(DateTime time)
        {
            var appointments = (Repository as IAppointmentRepository).SelectWithWhereCondition<Appointment>($"DesiredTime = {time}").ToList();
            return CreateDataTable(appointments);
        }

        public DataTable GetByPatientId(int id)
        {
            var appointments = (Repository as IRepository).SelectWithWhereCondition<Appointment>($"PatientID = {id}").ToList();
            return CreateDataTable(appointments);
        }

        public DataTable CreateDataTable(List<Appointment> appointments)
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("PatientId");
            dataTable.Columns.Add("First Name");
            dataTable.Columns.Add("Last Name");
            dataTable.Columns.Add("Age");
            dataTable.Columns.Add("Desired Date/Time");

            foreach (var appointment in appointments)
            {
                DataRow dataRow = dataTable.NewRow();
                var patient = patientManager.GetById<Patient>(appointment.PatientId);
                int dateNow = int.Parse(DateTime.Now.Year.ToString());
                int dateOfBirth = int.Parse(patient.BirthDate.Year.ToString());
                int age = dateNow - dateOfBirth;
                dataRow[0] = appointment.Id;
                dataRow[1] = appointment.PatientId;
                dataRow[2] = patient.FirstName;
                dataRow[3] = patient.LastName;
                dataRow[4] = age;
                dataRow[5] = appointment.DesiredDateTime;

                dataTable.Rows.Add(dataRow);
            }


            return dataTable;
        }
    }
}
