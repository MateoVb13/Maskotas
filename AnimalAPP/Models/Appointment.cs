using System;

namespace AnimalAPP.Models
{
    public class Appointment
    {
        public string PetName { get; set; } = string.Empty;
        public string Service { get; set; } = string.Empty;
        public DateTime AppointmentDateTime { get; set; }
    }
}
