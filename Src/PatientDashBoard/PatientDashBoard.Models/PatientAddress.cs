namespace PatientDashBoard.Models
{
    public class Address
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string PostCode { get; set; }
    }
}
