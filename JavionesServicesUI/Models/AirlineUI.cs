using Javiones.Core.Models;
using JavionesServicesUI.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JavionesServicesUI.Models
{
    public class AirlineUI
    {
        public static AirlineUI FromAirline(Airline aerolinea)
        {
            AirlineUI aerolineaUI = new AirlineUI
            {
                Id = aerolinea.Id,
                Name = aerolinea.Name,
                CreationYear = aerolinea.CreationYear,
                AvgAnnualInvoicing = aerolinea.AvgAnnualInvoicing,
            };
            return aerolineaUI;
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio"), StringLength(100, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 3 y 100 carácteres")]
        public string Name { get; set; }

        [MinimunYearValidator]
        public int CreationYear { get; set; }

        [Range(100.0, 100000.0, ErrorMessage = "Debe tener entre 100 y 100,000 €")]
        public decimal AvgAnnualInvoicing { get; set; }
    }
}