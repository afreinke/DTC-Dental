using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DTCDental.Models
{
    public class Patient
    {
        
        [Required]
        public int PatientID { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string StreetAddress { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public int Zip { get; set; }

        [Required]
        public long PhoneNumber { get; set; }
        
        [Required]
        public string Email { get; set; }

        
        public int? SocialSecurityNumber { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        public bool PatientMinor { get; set; }

        public int? HeadOfHouse { get; set; }

        public ICollection<Visit> Visits { get; set; } //navigation property
        public ICollection<Appointment> Appointments { get; set; } //navigation property
    }
}
