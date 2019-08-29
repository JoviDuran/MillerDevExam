using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuaClinic.Business.Repositories.Interfaces
{
    internal interface IConsultationRepository:IRepository
    {
        List<Consultation> GetByDate(DynamicParameters param);
    }
}
