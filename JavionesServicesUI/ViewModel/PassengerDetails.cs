using JavionesServicesUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JavionesServicesUI.ViewModel
{
    public class PassengerDetails
    {
        public string DNI { get; set; }
        public List<PlaneUI> Fliyings { get; set; }
        public decimal TotalBill { get; set; }
    }
}