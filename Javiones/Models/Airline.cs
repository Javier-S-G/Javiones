using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Javiones.Core.Models
{
    public class Airline
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CreationYear { get; set; }
        public int AvgAnnualInvoicing { get; set; }
    }
}