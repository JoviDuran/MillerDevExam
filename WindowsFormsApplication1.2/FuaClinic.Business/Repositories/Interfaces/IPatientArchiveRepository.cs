using Dapper;
using FuaClinic.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuaClinic.Business.Repositories.Interfaces
{
   internal interface IPatientArchiveRepository : IRepository
    {
        List<PatientArchive> SearchPatients(DynamicParameters param);

    }
}
