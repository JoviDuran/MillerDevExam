using FuaClinicApp.Business.Entities;
using FuaClinicApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuaClinicApp.Factories.Interfaces
{
    public interface IAddressFactory
    {
        AddressDTO CreateAddressDTO(Address address);
        IList<AddressDTO> CreateAddressDTO(IList<Address> addresses);


    }
}
