using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DTCDental.Models
{
    public class Appointment
    {
        [Required]
        public int AppointmentID { get; set; }

        //[Required]
        public Dentist Dentist { get; set; } //Navigation property

        public int DentistID { get; set; } //foreign key

        //[Required]
        public Patient Patient { get; set; } //navigation property

        public int PatientID { get; set; } //foreign key

        [Required]
        public Type Type { get; set; } //navigation property

        public int TypeID { get; set; } //Foreign key

        [Required]
        public DateTime AppointmentDate { get; set; }

        [Required]
        public DateTime AppointmentStartTime { get; set; }

        [Required]
        public DateTime AppointmentEndTime { get; set; }

    }
}
