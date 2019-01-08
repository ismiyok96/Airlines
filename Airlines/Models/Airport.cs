using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Airlines.Models
{
    public class Airport
    {
        [Key]
        public string AirportId { get; set; } = Guid.NewGuid().ToString(); //Unique Identifier of the Airport

        [Required]
        public string AirportName { get; set; } //Name of the Airport
        
        [Required]
        public string AirportCity { get; set; } //Location of the Airport (Only City)

        [Required]
        public string AirportCountry { get; set; } // Country of the Airport
        
        [Required]
        [StringLength(3)]
        public string AirportAbbre { get; set; } // Shortening of the Airport Name  

    }
}
