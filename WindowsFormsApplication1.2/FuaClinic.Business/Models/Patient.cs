using System;

namespace FuaClinic.Business
{
    public class Patient
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Occupation { get; set; }
        
    }
}
