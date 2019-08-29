using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuaClinicApp.Models
{
    public class Patient
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string BirthDate { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Occupation { get; set; }

    }
}