using FuaClinicApp.Business.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuaClinicApp.Business.Repositories
{
    class EmergencyContactRepository : BaseRepository, IEmergencyContactRepository
    {
        internal override string TableName => "EmergencyContacts";
    }
}
