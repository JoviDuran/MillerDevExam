using FuaClinicApp.Business.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuaClinicApp.Business.Repositories
{
    public class AppointmentRepository : BaseRepository, IAppointmentRepository
    {
        internal override string TableName => "Appointments";
    }
}
