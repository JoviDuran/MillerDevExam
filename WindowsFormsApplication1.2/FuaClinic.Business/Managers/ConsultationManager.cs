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
    public class ConsultationManager : BaseManager, IConsultationManager
    {
        internal override IRepository Repository => new ConsultationRepository();


        public DataTable GetAll()
        {
            var consultations = Repository.SelectAll<Consultation>().ToList();
            return CreateDataTable(consultations);
        }


        public DataTable GetByDate(DynamicParameters param)
        {
            var consultations = (Repository as IConsultationRepository).GetByDate(param);
            return CreateDataTable(consultations);
        }


        public DataTable GetByPatientId(int id)
        {
            var consultations = (Repository as IConsultationRepository).SelectWithWhereCondition<Consultation>($"PatientID = {id}").ToList();
            return CreateDataTable(consultations);

        }

        public DataTable CreateDataTable(List<Consultation> consultations)
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("PatientId");
            dataTable.Columns.Add("Diagnosis");
            dataTable.Columns.Add("Date");

            foreach (var consultation in consultations)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow[0] = consultation.Id;
                dataRow[1] = consultation.PatientId;
                dataRow[2] = consultation.Diagnosis;
                dataRow[3] = consultation.Date.ToShortDateString();

                dataTable.Rows.Add(dataRow);
            }

            return dataTable;
        }

    }
}
