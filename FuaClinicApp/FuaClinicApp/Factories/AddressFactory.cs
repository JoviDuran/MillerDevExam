using FuaClinicApp.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FuaClinicApp.Business.Entities;
using FuaClinicApp.Models;

namespace FuaClinicApp.Factories
{
    public class AddressFactory : IAddressFactory
    {
        public AddressDTO CreateAddressDTO(Address address)
        {
            var addressDTO = new AddressDTO()
            {
                Id = address.Id,
                PatientId = address.PatientId,
                City = address.City,
                Province = address.Province,
                PostalCode = address.PostalCode
            };

            return addressDTO;
        }

        public IList<AddressDTO> CreateAddressDTO(IList<Address> addresses)
        {
            var addressesDTO = new List<AddressDTO>();
            foreach (var address in addresses)
            {
                var addressDTO = CreateAddressDTO(address);
                addressesDTO.Add(addressDTO);
            }

            return addressesDTO;
        }
    }
}