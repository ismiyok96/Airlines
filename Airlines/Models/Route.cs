using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airlines.Models
{
    public class Route
    {
        public string CountryName { get; set; }
        public string CityName { get; set; }
        public string AirportName { get; set; }
        public int AirportID { get; set; }
    }
}
