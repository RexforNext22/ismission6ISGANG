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

<<<<<<< HEAD
<<<<<<< Updated upstream

=======
        private readonly ILogger<HomeController> _logger;
>>>>>>> 088bd205eb423f126b9a445e31e39f515764163b

        private TasksContext taContext { get; set; }
=======
>>>>>>> Stashed changes

        public HomeController(TasksContext someName)
        {
            taContext = someName;
        }

        [HttpGet]
        public  IActionResult Quadrant()
        {
            ViewBag.Tasks = taContext.responses.ToList();
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
        public IActionResult TaskForm()
        {

            return View();

            //if (ModelState.IsValid)
            //{
            //    taContext.Add(tr);
            //    taContext.SaveChanges();
            //    return View("Confirmation");
            //}
            //else
            //{
            //    ViewBag.Category = taContext.Category.ToList();
            //    return View(tr);

<<<<<<< Updated upstream
        
=======

       public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
>>>>>>> Stashed changes
        }
    }
}
