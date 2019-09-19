using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuaClinic.Business.Models
{
    public class TestResult
    {
        public int Id { get; set; }
        public int AppointmentId { get; set; }
        public string Name { get; set; }
        public byte[] Image { get; set; }
    }
}
