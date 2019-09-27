﻿using System;

namespace FuaClinic.Business
{
    public class Consultation
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int? AppointmentId { get; set; }

        public string Diagnosis { get; set; }
        public DateTime DateTime { get; set; }
    }
}
