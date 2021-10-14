using Javiones.Core.Services;
using JavionesServicesUI.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JavionesServicesUI.Controllers
{
    public class BillingController : Controller
    {
        private readonly IBillingService _billingService;

        public BillingController(IBillingService billingService)
        {
            _billingService = billingService;
        }

        public IActionResult Index()
        {
            Tuple<decimal, int> costAndNumber = _billingService.GetTotalCostAndNumberOfBillings();
            return View(new BillingResume { TotalCost = costAndNumber.Item1, NumberOfBillings = costAndNumber.Item2 });
        }
    }
}