using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DTCDental.Models
{
    public class Type
    {
        [Required]
        public int TypeID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int Duration { get; set; }

        public ICollection<Appointment> Appointments { get; set; } //navigation property
    }
}
