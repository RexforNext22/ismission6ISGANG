// Author: Ryan Pinkney, Jacob Poor, Tanner Davis, Kevin Gutierrez
// This is the controller for our site.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ismission6ISGANG.Models;
using Microsoft.EntityFrameworkCore;

namespace ismission6ISGANG.Controllers
{
    public class HomeController : Controller


    {
        private readonly ILogger<HomeController> _logger;


        private TasksContext DbContext { get; set; }

        public HomeController(TasksContext someName)
        {
            DbContext = someName;
        }

        [HttpGet]
        public  IActionResult Quadrant()
        {

            // Pull a list of all tasks from the database using tolist()
            var lstDataList = DbContext.responses
                .Include(x => x.Category)
                .ToList();

            return View(lstDataList);
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult TaskForm()
        {
            ViewBag.Category = taContext.Category.ToList();
            return View();
        }
        public IActionResult TaskForm()
        {

            return View();
        }
       public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}
