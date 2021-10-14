using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Javiones.Core.Models
{
    public class Plane
    {
        public string LicensePlate { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int FabricationYear { get; set; }
        public int Revision { get; set; }
        public int AirlineId { get; set; }
    }
}