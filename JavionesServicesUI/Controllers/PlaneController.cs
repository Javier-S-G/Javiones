using Microsoft.AspNetCore.Mvc;
using Javiones.Core.Models;
using Javiones.Core.Services;
using JavionesServicesUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JavionesServicesUI.Controllers
{
    public class PlaneController : Controller
    {
        private readonly IPlaneService _planeService;

        public PlaneController(IPlaneService planeService)
        {
            _planeService = planeService;
        }

        public IActionResult Index()
        {
            List<Plane> planes = _planeService.GetPlanesOrderByPassengersNumber();
            List<PlaneUI> orderedPlanes = new List<PlaneUI>();
            foreach (var plane in planes)
            {
                orderedPlanes.Add(PlaneUI.FromPlane(plane));
            }
            return View(orderedPlanes);
        }
    }
}