using System;

namespace PatientDashBoard.Models
{
    public class Appointments 
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public DateTime AppointmentDateTime { get; set; }
        public string ReasonForAppointment { get; set; }
        public int Duration { get; set; }
        public string status { get; set; }
    }
}
