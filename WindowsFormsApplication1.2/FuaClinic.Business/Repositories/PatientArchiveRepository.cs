using FuaClinic.Business.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using FuaClinic.Business.Models;
using System.Data;

namespace FuaClinic.Business.Repositories
{
    public class PatientArchiveRepository : BaseRepository, IPatientArchiveRepository
    {
        internal override string TableName => "PatientArchive";

        public List<PatientArchive> SearchPatients(DynamicParameters param)
        {
            var result = Connection.Query<PatientArchive>("SearchPatientArchive", param, commandType:
            CommandType.StoredProcedure).ToList();
            return result;
        }
    }
       
}
