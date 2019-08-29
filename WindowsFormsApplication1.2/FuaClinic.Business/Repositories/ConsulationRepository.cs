using System.Data;
using System.Linq;
using Dapper;
using System.Collections.Generic;
using FuaClinic.Business.Repositories.Interfaces;
using System;

namespace FuaClinic.Business.Repositories
{
    public class ConsultationRepository : BaseRepository, IConsultationRepository
    {
        internal override string TableName => "Consultations";

        public List<Consultation> GetByDate(DynamicParameters param)
        {
            var result = Connection.Query<Consultation>("SearchConsultationByDate", param, commandType:
            CommandType.StoredProcedure).ToList();
            return result;
        }
    }
}
