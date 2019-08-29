using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using FuaClinic.Business.Repositories.Interfaces;

namespace FuaClinic.Business.Repositories
{
    public class AddressRepository : BaseRepository, IAddressRepository
    {
        internal override string TableName => "Addresses";
    }
}
