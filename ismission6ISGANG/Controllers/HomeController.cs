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

        // Set the DbContext
        private TasksContext DbContext { get; set; }

        public HomeController(TasksContext someName)
        {
            DbContext = someName;
        }

        // Get method to return the quadrant view
        [HttpGet]
        public  IActionResult Quadrant()
        {

            // Pull a list of all tasks from the database using tolist()
            var lstDataList = DbContext.responses
                .Include(x => x.Category)
                .ToList();

            // Return the list of data
            return View(lstDataList);
        }

        // Get method to return the index
        public IActionResult Index()
        {
            return View();
        }

        // Get method to return the tasks view
        public IActionResult Tasks()
        {
            return View();
        }

        // get method to return the taskform
        public IActionResult TaskForm()
        {

            return View();
        }

        // get method for edit
       public IActionResult Edit()
        {
            return View();
        }

        // get method for delete
        public IActionResult Delete()
        {
            return View();
        }
    }
}
