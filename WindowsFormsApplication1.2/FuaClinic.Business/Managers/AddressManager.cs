using FuaClinic.Business.Managers.ManagerInterfaces;
using FuaClinic.Business.Repositories;
using FuaClinic.Business.Repositories.Interfaces;
using System.Collections.Generic;

namespace FuaClinic.Business.Managers
{
    public class AddressManager : BaseManager, IAddressManager
    {
        internal override IRepository Repository => new AddressRepository();
    }
}
