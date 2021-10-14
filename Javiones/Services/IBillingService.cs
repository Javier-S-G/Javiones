using Javiones.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Javiones.Core.Services
{
    public interface IBillingService
    {
        List<Billing> GetAllBillings();

        // Mostrar cual es coste total de la facturación y cuantas facturaciones se han hecho.
        Tuple<decimal, int> GetTotalCostAndNumberOfBillings();
    }
}