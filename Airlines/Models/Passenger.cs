using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Airlines.Models
{
    public class Passenger
    {
        [Key]
        public int PassengerID { get; set; }

        [Required]
        public string PassengerDocumentType { get; set; }

        [Required]
        public string PassengerDocumentNumber { get; set; }

        [StringLength(12)]
        public string PassengerTicketNumber { get; set; }

        [Required]
        public string PassengerFirstName { get; set; }

        [Required]
        public string PassengerLastName { get; set; }

        public string PassengerPhone { get; set; }

        [DataType(DataType.Date)]
        public int PassengerBirthDate { get; set; }

        public string PassengerSex { get; set; }
    }
}
