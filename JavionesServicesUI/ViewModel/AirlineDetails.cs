using JavionesServicesUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JavionesServicesUI.ViewModel
{
    public class AirlineDetails
    {
        public List<PlaneUI> AirlinePlanes { get; set; }
        public string AirlineName { get; set; }
    }
}