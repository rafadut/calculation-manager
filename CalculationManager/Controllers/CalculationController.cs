using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CalculationManagerProject.Controllers
{
    public class CalculationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}