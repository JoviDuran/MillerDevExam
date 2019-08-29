using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuaClinicApp.Business.Models
{
    public class PatientArchive
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
        public DateTime DeletedAt => DateTime.Now;
    }
}
