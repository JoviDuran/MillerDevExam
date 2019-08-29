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
    public class AppointmentRepository : BaseRepository, IAppointmentRepository
    {
        internal override string TableName => "Appointments";
    }
}
