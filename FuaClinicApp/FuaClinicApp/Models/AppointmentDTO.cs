using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuaClinicApp.Models
{
    public class AppointmentDTO
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public DateTime DesiredDateTime { get; set; }
    }
}