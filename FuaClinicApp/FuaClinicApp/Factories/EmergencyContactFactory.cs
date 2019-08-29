using FuaClinicApp.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FuaClinicApp.Business.Entities;
using FuaClinicApp.Models;

namespace FuaClinicApp.Factories
{
    public class EmergencyContactFactory : IEmergencyContactFactory
    {
        public EmergencyContactDTO CreateEmergencyContactDTO(EmergencyContact emergencyContact)
        {
            var emergencyContactDTO = new EmergencyContactDTO()
            { 
                Id = emergencyContact.Id,
                PatientId = emergencyContact.PatientId,
                FirstName = emergencyContact.FirstName,
                LastName  = emergencyContact.LastName,
                ContactNumber = emergencyContact.ContactNumber
            };

            return emergencyContactDTO;
        }

        public IList<EmergencyContactDTO> CreateEmergencyContactDTO(IList<EmergencyContact> emergencyContacts)
        {
            var emergencyContactsDTO = new List<EmergencyContactDTO>();
            foreach (var emergencyContact in emergencyContacts)
            {
                var emergencyContactDTO = CreateEmergencyContactDTO(emergencyContact);
                emergencyContactsDTO.Add(emergencyContactDTO);
            }

            return emergencyContactsDTO;
        }

        
    }
}