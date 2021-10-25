using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DTCDental.Models
{
    public class Service
    {
        [Required]
        public int ServiceID { get; set; }

        [Required]
        public DateTime ServiceDate { get; set; }

        [Required]
        public decimal ServiceCost { get; set; }

        public ICollection<CompletedService> CompletedServices { get; set; } //Navigation property to linking entity
    }
}
