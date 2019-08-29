namespace FuaClinic.Business

{
    public class Address
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
    }
}
