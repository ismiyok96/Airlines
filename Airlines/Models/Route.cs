using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Airlines.Models
{
    public class Route
    {
        public string DepartureAirport { get; set; }
        public string ArrivalAirport { get; set; }        
        public string DepartureTime { get; set; }
        public string ArrivalTime { get; set; }


    }
}
