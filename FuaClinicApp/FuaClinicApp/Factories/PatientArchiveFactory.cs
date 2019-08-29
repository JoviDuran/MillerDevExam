using FuaClinicApp.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FuaClinicApp.Business.Entities;
using FuaClinicApp.Models;

namespace FuaClinicApp.Factories
{
    public class PatientArchiveFactory : IPatientArchiveFactory
    {
        public IList<PatientArchiveDTO> CreatePatientArchiveDTO(IList<PatientArchive> patientArchives)
        {
            var patientArchivesDTO = new List<PatientArchiveDTO>();

            foreach (var patientArchive in patientArchives)
            {
                //var address = addresses.Where(x => x.PatientId == patientArchive.Id).FirstOrDefault();
                //var emergencyContact = emergencyContacts.Where(x => x.PatientId == patientArchive.Id).FirstOrDefault();
                var patientArchiveDTO = CreatePatientArchiveDTO(patientArchive);
                patientArchivesDTO.Add(patientArchiveDTO);
            }

            return patientArchivesDTO;
        }

        public PatientArchiveDTO CreatePatientArchiveDTO(PatientArchive patientArchive)
        {
            var patientArchiveDTO = new PatientArchiveDTO()
            {
                Id = patientArchive.Id,
                FirstName = patientArchive.FirstName,
                LastName = patientArchive.LastName,
                Gender = patientArchive.Gender,
                BirthDate = patientArchive.BirthDate,
                ContactNumber = patientArchive.ContactNumber,
                Email = patientArchive.Email,
                Occupation = patientArchive.Occupation,
                Address = patientArchive.Address,
                EmergencyContact = patientArchive.EmergencyContact,
                DeletedAt = patientArchive.DeletedAt
            };

            return patientArchiveDTO;
        }

        // Not sure in creating PatientArchiveDTO


    }
}