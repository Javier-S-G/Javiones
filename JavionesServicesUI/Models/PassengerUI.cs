using Javiones.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JavionesServicesUI.Models
{
    public class PassengerUI
    {
        public static PassengerUI FromPassenger(Passenger pasajero)
        {
            PassengerUI pasajeroUI = new PassengerUI
            {
                Dni = pasajero.Dni,
                FullName = pasajero.FullName,
                BirthDate = pasajero.BirthDate,
                Retired = pasajero.Retired
            };
            return pasajeroUI;
        }

        [DataType(DataType.Text), StringLength(12, MinimumLength = 10, ErrorMessage = "El DNI debe tener entre 10 y 12 carácteres")]
        public string Dni { get; set; }

        [DataType(DataType.Text), StringLength(100, MinimumLength = 2, ErrorMessage = "El nombre debe tener entre 10 y 12 carácteres")]
        public string FullName { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime BirthDate { get; set; }

        public bool Retired { get; set; }
    }
}