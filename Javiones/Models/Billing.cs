using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Javiones.Core.Models
{
    public class Billing
    {
        public string LicensePlate { get; set; }
        public string PassengerDNI { get; set; }
        public DateTime FliyingDate { get; set; }
        public decimal Cost { get; set; }
    }
}