using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Airlines.Models
{
    public class Plane
    {
        [Key]
        public int PlaneID { get; set; }

        public string PlaneModel { get; set; }

        [Required]
        public string PlaneCapacity { get; set; }

        public string PlaneType { get; set; }
    }
}
