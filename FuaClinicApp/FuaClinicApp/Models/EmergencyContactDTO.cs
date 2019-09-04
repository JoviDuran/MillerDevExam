﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuaClinicApp.Models
{
    public class EmergencyContactDTO
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
    }
}