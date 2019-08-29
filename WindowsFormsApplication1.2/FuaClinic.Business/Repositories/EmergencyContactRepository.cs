using Dapper;
using System.Linq;
using System.Collections.Generic;
using FuaClinic.Business.Repositories.Interfaces;

namespace FuaClinic.Business.Repositories
{
    public class EmergencyContactRepository : BaseRepository, IEmergencyContactRepository
    {
        internal override string TableName => "EmergencyContacts";
    }
}
