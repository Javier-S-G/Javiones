using Javiones.Core.Models;
using JavionesServicesUI.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JavionesServicesUI.Models
{
    public class PlaneUI
    {
        public static PlaneUI FromPlane(Plane plane)
        {
            PlaneUI planeUI = new PlaneUI
            {
                LicensePlate = plane.LicensePlate,
                Brand = plane.Brand,
                Model = plane.Model,
                FabricationYear = plane.FabricationYear,
                Revision = plane.Revision,
                AirlineId = plane.AirlineId,
            };
            return planeUI;
        }

        [DataType(DataType.Text), StringLength(10, ErrorMessage = "La matrícula no debe tener más de 10 carácteres")]
        public string LicensePlate { get; set; }

        [DataType(DataType.Text), StringLength(100, MinimumLength = 3, ErrorMessage = "La marca debe tener entre 3 y 100 carácteres")]
        public string Brand { get; set; }

        [DataType(DataType.Text), StringLength(100, MinimumLength = 3, ErrorMessage = "El modelo debe tener entre 3 y 100 carácteres")]
        public string Model { get; set; }

        [MinimunYearValidator]
        public int FabricationYear { get; set; }

        [Range(0, 100, ErrorMessage = "La revisión debe tener entre 1 y 100 carácteres")]
        public int Revision { get; set; }

        [Range(0, int.MaxValue)]
        public int AirlineId { get; set; }
    }
}