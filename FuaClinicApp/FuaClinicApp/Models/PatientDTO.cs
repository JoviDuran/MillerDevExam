using FuaClinicApp.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuaClinicApp.Models
{
    public class PatientDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string BirthDate { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Occupation { get; set; }
        public Address Address { get; set; }
        public EmergencyContact EmergencyContact { get; set; }
        public IList<Consultation> Consultations { get; set; } = new List<Consultation>();
        public IList<Appointment> Appointments { get; set; } = new List<Appointment>();

    }
}