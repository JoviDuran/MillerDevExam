namespace FuaClinic.Business
{
    public class EmergencyContact
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
    }
}
