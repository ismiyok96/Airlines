using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airlines.Models
{
    public class Airport
    {
        public string AirportName { get; set; } //Name of the Airport
        public string AirportCity { get; set; } //Location of the Airport (Only City)
        public string AirportCountry { get; set; } // Country of the Airport
        public string Id { get; set; } = Guid.NewGuid().ToString(); //Unique Identifier of the Airport
        public string AirportAbbre { get; set; } // Shortening of the Airport Name  

    }
}
