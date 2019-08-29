using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuaClinic.Business.Managers.ManagerInterfaces
{
    public interface IConsultationManager : IManager
    {
        DataTable GetAll();
        DataTable GetByDate(DynamicParameters param);
        DataTable GetByPatientId(int id);
    }
}
