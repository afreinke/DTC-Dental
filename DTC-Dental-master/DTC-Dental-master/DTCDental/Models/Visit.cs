using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DTCDental.Models
{
    public class Visit
    {
        [Required]
        public int VisitID { get; set; }
        
        [Required]
        public int DentistID { get; set; } //foreign key

        [Required]
        public Dentist Dentist { get; set; } //navigation property

        
        public int PatientID { get; set; } //foreign key

        [Required]
        public Patient Patient { get; set; } //Navigation property

        public ICollection<CompletedService> CompletedServices { get; set; } //navigation property to linking entity

        [Required]
        public DateTime VisitDate { get; set; }


    }
}
