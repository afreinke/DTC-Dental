using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DTCDental.Models
{
    public class Dentist
    {
        [Required]
        public int DentistID { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime HireDate { get; set; }

        public ICollection<Visit> Visits { get; set; } //Navigation property

        public ICollection<Appointment> Appointments { get; set; } //navigation property
    }
}
