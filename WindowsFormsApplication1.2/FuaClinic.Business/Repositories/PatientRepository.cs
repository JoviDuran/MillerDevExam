using System.Data;
using System.Linq;
using Dapper;
using System.Collections.Generic;
using FuaClinic.Business.Repositories.Interfaces;
using System;

namespace FuaClinic.Business.Repositories
{
    public class PatientRepository : BaseRepository, IPatientRepository
    {
        internal override string TableName => "Patients";

        public List<Patient> SearchPatients(DynamicParameters param)
        {
            var result = Connection.Query<Patient>("SearchPatients", param, commandType:
            CommandType.StoredProcedure).ToList();
            return result;
        }
    }
}
