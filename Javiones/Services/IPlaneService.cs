using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Javiones.Core.Services
{
    public interface IPlaneService
    {
        List<Plane> GetAllPlanes();

        // Mostrar que aviones tienen más pasajeros, ordenados de mayor a menor.
        List<Plane> GetPlanesOrderByPassengersNumber();
    }
}