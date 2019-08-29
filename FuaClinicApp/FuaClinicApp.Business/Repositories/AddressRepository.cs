using FuaClinicApp.Business.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuaClinicApp.Business.Repositories
{
    public class AddressRepository : BaseRepository, IAddressRepository
    {
        internal override string TableName => "Addresses";
    }
}
