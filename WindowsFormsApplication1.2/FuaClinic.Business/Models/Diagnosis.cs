using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuaClinic.Business
{
    public class Diagnosis
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public string Illness { get; set; }
        public string Date { get; set; }
    }
}
