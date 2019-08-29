using Dapper;
using FuaClinicApp.Business.Entities;
using FuaClinicApp.Business.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuaClinicApp.Business.Repositories
{
    class ConsultationRepository : BaseRepository, IConsultationRepository
    {
        internal override string TableName => "Consultations";

       
    }
}
