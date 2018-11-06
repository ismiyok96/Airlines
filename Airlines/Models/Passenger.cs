using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airlines.Models
{
    public class Passanger
    {
        public int PID { get; set; }
        public int Pnr { get; set; }
        public int PassportNo { get; set; }
        public string FlıghtCode { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
    }
}
