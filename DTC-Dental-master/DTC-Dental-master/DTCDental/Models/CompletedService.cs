using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DTCDental.Models
{
    public class CompletedService
    {
        public int ServiceID { get; set; } //foreign key

        [Required]
        public Service Service { get; set; } //navigation property

        public int VisitID { get; set; } //foreign key

        [Required]
        public Visit Visit { get; set; } //navigation property

        
    }
}
