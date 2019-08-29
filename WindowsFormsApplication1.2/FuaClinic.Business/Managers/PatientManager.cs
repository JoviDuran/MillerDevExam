using Dapper;
using FuaClinic.Business.Managers.ManagerInterfaces;
using FuaClinic.Business.Repositories;
using FuaClinic.Business.Repositories.Interfaces;
using System.Collections.Generic;
using System.Data;
using System;
using System.Linq;

namespace FuaClinic.Business.Managers
{
    public class PatientManager : BaseManager, IPatientManager
    {
        internal override IRepository Repository => new PatientRepository();

        public DataTable GetAll()
        {
            var patients = Repository.SelectAll<Patient>().ToList();
            return CreateDataTable(patients);
        }


        public DataTable GetBySearch(DynamicParameters param)
        {
            var patients = (Repository as IPatientRepository).SearchPatients(param);
            return CreateDataTable(patients);
        }

        public DataTable CreateDataTable(List<Patient> patients)
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("First Name");
            dataTable.Columns.Add("Last Name");
            dataTable.Columns.Add("Gender");
            dataTable.Columns.Add("BirthDate");
            dataTable.Columns.Add("Email");
            dataTable.Columns.Add("Occupation");
            dataTable.Columns.Add("ContactNumber");

            foreach (var patient in patients)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow[0] = patient.Id;
                dataRow[1] = patient.FirstName;
                dataRow[2] = patient.LastName;
                dataRow[3] = patient.Gender;
                dataRow[4] = patient.BirthDate;
                dataRow[5] = patient.Email;
                dataRow[6] = patient.Occupation;
                dataRow[7] = patient.ContactNumber;

                dataTable.Rows.Add(dataRow);
            }

            return dataTable;
        }
    }
}
