using FuaClinicApp.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuaClinicApp.Models
{
    public class PatientArchiveDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Occupation { get; set; }

        public string Address { get; set; }
        public string EmergencyContact { get; set; }
        public DateTime DeletedAt { get; set; } = DateTime.Now;
    }
}