using FuaClinicApp.Business.Entities;
using FuaClinicApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuaClinicApp.Factories.Interfaces
{
    public interface IPatientFactory
    {
        PatientDTO CreatePatientDTO(Patient patient, Address address, EmergencyContact emergencyContact, IList<Consultation> consultations, IList<Appointment> appointments);
        IList<PatientDTO> CreatePatientDTO(IList<Patient> patients, IList<Address> addresses, IList<EmergencyContact> emergencyContacts, IList<Consultation> consultations, IList<Appointment> appointments);
    }
}
