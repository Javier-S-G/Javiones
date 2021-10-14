using Javiones.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Javiones.Core.Services
{
    public interface IPassengerService
    {
        List<Passenger> GetAllPassengers();

        // Mostrar que pasajeros han volado mas.
        List<Passenger> GetPassengersByNumberOfFlights();

        // Mostrar para un pasajero, cual es su facturación total y los aviones en los que ha viajado.
        Tuple<decimal, List<Plane>> GetBillResumeForPassenger(string dni);
    }
}