using FuaClinic.Business.Managers.ManagerInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuaClinic.Business.Repositories.Interfaces;
using FuaClinic.Business.Repositories;
using FuaClinic.Business.Models;
using System.Data;
using Dapper;

namespace FuaClinic.Business.Managers
{
    public class PatientArchiveManager : BaseManager, IPatientArchiveManager
    {
        internal override IRepository Repository => new PatientArchiveRepository();

        public DataTable GetAll()
        {
            var patients = Repository.SelectAll<PatientArchive>().ToList();
            return CreateDataTable(patients);
        }

        public DataTable GetBySearch(DynamicParameters param)
        {
            var patients = (Repository as IPatientArchiveRepository).SearchPatients(param);
            return CreateDataTable(patients);
        }

        public DataTable CreateDataTable(List<PatientArchive> patients)
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("First Name");
            dataTable.Columns.Add("Last Name");
            dataTable.Columns.Add("Gender");
            dataTable.Columns.Add("Birth Date");
            dataTable.Columns.Add("Email");
            dataTable.Columns.Add("Occupation");
            dataTable.Columns.Add("ContactNumber");
            dataTable.Columns.Add("Address");
            dataTable.Columns.Add("Emergency Contact");
            dataTable.Columns.Add("Deleted At");

            foreach (var patient in patients)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow[0] = patient.FirstName;
                dataRow[1] = patient.LastName;
                dataRow[2] = patient.Gender;
                dataRow[3] = patient.BirthDate;
                dataRow[4] = patient.Email;
                dataRow[5] = patient.Occupation;
                dataRow[6] = patient.ContactNumber;
                dataRow[7] = patient.Address;
                dataRow[8] = patient.EmergencyContact;
                dataRow[9] = patient.DeletedAt;

                dataTable.Rows.Add(dataRow);
            }

            return dataTable;
        }
    }
}
