using Javiones.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Javiones.Core.Services
{
    public interface IAirlineService
    {
        // Mostrar todos las Aerolineas, y entre parentesis poner el numero de aviones que tiene.
        List<Airline> GetAllAirlines();

        List<Plane> GetAirlinePlanes(int airlineId);

        // Mostrar cuando se vea el detalle de la aerolinea, una lista con todos los aviones que tiene.
        List<Tuple<Airline, int>> GetAllAirlinesWithPlanes();
    }
}