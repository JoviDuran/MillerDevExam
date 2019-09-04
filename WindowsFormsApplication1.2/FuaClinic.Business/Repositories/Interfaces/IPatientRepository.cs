using Dapper;
using FuaClinic.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuaClinic.Business.Repositories.Interfaces
{
    internal interface IPatientRepository:IRepository
    {
        List<Patient> SearchPatients(DynamicParameters param);
    }
}
