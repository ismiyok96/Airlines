using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Airlines.Models;

namespace Airlines.Models
{
    public class Route
    {
        [Required]
        public string FlightNumber { get; set; } //Number of flights.

        public Plane PlaneNumber { get; set; } // Number of plane which will use for flight.

        [Required]
        public Airport DepartureAirport { get; set; } //Information of departure airport.

        [Required]
        public Airport ArrivalAirport { get; set; } // Information of arrival airport.

        [DataType(DataType.Date)]
        public string DepartureTime { get; set; } // Information of departure time.

        [DataType(DataType.Date)]
        public string ArrivalTime { get; set; } // Information of arrival time.

    }
}
