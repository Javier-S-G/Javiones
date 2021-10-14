using Javiones.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JavionesServicesUI.Models
{
    public class BillingUI
    {
        public static BillingUI FromBilling(Billing facturacion)
        {
            BillingUI facturacionUI = new BillingUI
            {
                LicensePlate = facturacion.LicensePlate,
                PassengerDNI = facturacion.PassengerDNI,
                FliyingDate = facturacion.FliyingDate,
                Cost = facturacion.Cost
            };
            return facturacionUI;
        }

        public string LicensePlate { get; set; }
        public string PassengerDNI { get; set; }
        public DateTime FliyingDate { get; set; }
        public decimal Cost { get; set; }
    }
}