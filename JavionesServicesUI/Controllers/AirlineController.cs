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
    public class AirlineController : Controller
    {
        private readonly IAirlineService _airlineService;

        public AirlineController(IAirlineService airlineService)
        {
            _airlineService = airlineService;
        }

        public IActionResult Index()
        {
            List<Tuple<Airline, int>> airlines = _airlineService.GetAllAirlinesWithPlanes();
            List<Tuple<AirlineUI, int>> airlinesUI = new List<Tuple<AirlineUI, int>>();

            foreach (var item in airlines)
            {
                airlinesUI.Add(new Tuple<AirlineUI, int>(AirlineUI.FromAirline(item.Item1), item.Item2));
            }

            return View(airlinesUI);
        }

        public IActionResult ShowDetails(int id)
        {
            Airline airline = _airlineService.GetAllAirlines().FirstOrDefault(item => item.Id == id);
            List<Plane> planes = _airlineService.GetAirlinePlanes(id);
            List<PlaneUI> airlinePlanes = new List<PlaneUI>();

            foreach (var plane in planes)
            {
                airlinePlanes.Add(PlaneUI.FromPlane(plane));
            }

            return View(new AirlineDetails { AirlinePlanes = airlinePlanes, AirlineName = airline.Name });
        }

        public IActionResult AddAirline(AirlineUI airline)
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveAirline(AirlineUI airline)
        {
            if (!ModelState.IsValid)
            {
                return Redirect("AddAirline");
            }
            return View();
        }
    }
}