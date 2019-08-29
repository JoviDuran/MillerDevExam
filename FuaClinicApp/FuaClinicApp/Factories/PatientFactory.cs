using FuaClinicApp.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FuaClinicApp.Business.Entities;
using FuaClinicApp.Models;

namespace FuaClinicApp.Factories
{
    public class PatientFactory : IPatientFactory
    {
        public PatientDTO CreatePatientDTO(Patient patient, Address address, EmergencyContact emergencyContact, IList<Consultation> consultations, IList<Appointment> appointments)
        {
            var patientDTO = new PatientDTO
            {
                Id = patient.Id,
                FirstName = patient.FirstName,
                LastName = patient.LastName,
                Gender = patient.Gender,
                BirthDate = patient.BirthDate,
                ContactNumber = patient.ContactNumber,
                Email = patient.Email,
                Occupation = patient.Occupation,
                Address = address,
                EmergencyContact = emergencyContact,
                Consultations = consultations,
                Appointments = appointments
            };

            return patientDTO;
        }

        
        public IList<PatientDTO> CreatePatientDTO(IList<Patient> patients, IList<Address> addresses, IList<EmergencyContact> emergencyContacts, IList<Consultation> consultations, IList<Appointment> appointments)
        {
            var patientsDTO = new List<PatientDTO>();

            foreach (var patient in patients)
            {
                var address = addresses.Where(x => x.PatientId == patient.Id).FirstOrDefault();
                var emergencyContact = emergencyContacts.Where(x => x.PatientId == patient.Id).FirstOrDefault();
                var consultation = consultations.Where(x => x.PatientId == patient.Id).ToList();
                var appointment = appointments.Where(x => x.PatientId == patient.Id).ToList();
                var patientDTO = CreatePatientDTO(patient, address, emergencyContact, consultation, appointment);
                patientsDTO.Add(patientDTO);
            }

            return patientsDTO;
        }

    }
}