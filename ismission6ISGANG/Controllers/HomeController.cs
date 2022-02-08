using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ismission6ISGANG.Models;

namespace ismission6ISGANG.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public  IActionResult Quadrant()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Tasks()
        {
            return View();
        }

    }
}
