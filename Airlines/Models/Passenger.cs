using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airlines.Models
{
    public class Passenger
    {
        public int PassengerID { get; set; }
        public string PassportNo { get; set; }
        public string TicketNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PassengerPhone { get; set; }
        public int PassengerAge { get; set; }
        public string PassengerSex { get; set; }
    }
}
