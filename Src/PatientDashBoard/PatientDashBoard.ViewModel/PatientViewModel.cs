using System;

namespace PatientDashBoard.ViewModel
{
    public class PatientViewModel
    {
        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NhsNumber { get; set; }
        public DateTime Dob { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Status { get; set; }
        public bool Deleted { get; set; }
    }
}
