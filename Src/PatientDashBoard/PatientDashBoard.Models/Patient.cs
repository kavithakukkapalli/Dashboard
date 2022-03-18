using System;

namespace PatientDashBoard.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NhsNumber { get; set; }
        public DateTime Dob { get; set; }
        public string EMail { get; set; }
        public string PhoneNumber { get; set; }
        public string Status { get; set; }
        public bool Deleted { get; set; }
    }
}
