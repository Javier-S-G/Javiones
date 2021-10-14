using Javiones.Core.Models;
using Javiones.Core.Services;
using JavionesServicesUI.Models;
using JavionesServicesUI.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JavionesServicesUI.Controllers
{
    public class PassengerController : Controller
    {
        private readonly IPassengerService _passengerService;

        public PassengerController(IPassengerService passengerService)
        {
            _passengerService = passengerService;
        }

        public IActionResult Index()
        {
            List<Passenger> passengers = _passengerService.GetPassengersByNumberOfFlights();
            List<PassengerUI> orderedPassengers = new List<PassengerUI>();
            foreach (var passenger in passengers)
            {
                orderedPassengers.Add(PassengerUI.FromPassenger(passenger));
            }
            return View(orderedPassengers);
        }

        public IActionResult ShowDetails(string dni)
        {
            Tuple<decimal, List<Plane>> passengerData = _passengerService.GetBillResumeForPassenger(dni);

            List<PlaneUI> planes = new List<PlaneUI>();
            foreach (var plane in passengerData.Item2)
            {
                planes.Add(PlaneUI.FromPlane(plane));
            }

            return View(new PassengerDetails { DNI = dni, TotalBill = passengerData.Item1, Fliyings = planes });
        }
    }
}