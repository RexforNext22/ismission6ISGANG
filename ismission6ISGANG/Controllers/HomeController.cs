﻿// Author: Ryan Pinkney, Jacob Poor, Tanner Davis, Kevin Gutierrez
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
                .Where(x => x.Completed == false)
                .ToList();

            // Return the list of data
            return View(lstDataList);
        }

        // Get method to return the index
        public IActionResult Index()
        {
            return View();
        }

        // Get method for the taskform
        [HttpGet]
        public IActionResult TaskForm()
        {
            ViewBag.Category = DbContext.Category.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult TaskForm(Tasks ar)
        {
            ViewBag.Category = DbContext.Category.ToList();
            //checks to see if submit is valid if so to submit
            if (ModelState.IsValid)
            {
                DbContext.Add(ar);
                DbContext.SaveChanges();
                return RedirectToAction("Quadrant", ar);
            }
            else
            {

                return View();

            }
        }
        // Get method for the edit
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Category = DbContext.Category.ToList();

            var application = DbContext.responses.Single(x => x.TaskID == id);

            return View(application);
        }

        // Post method for the edit
        [HttpPost]
        public IActionResult Edit(Tasks Inst)
        {

            DbContext.Update(Inst);
            DbContext.SaveChanges();

            return RedirectToAction("Quadrant");


        }

        // Get method for the delete
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var tasks = DbContext.responses.Single(x => x.TaskID == id);
            return View(tasks);
        }

        // Post method for the delete
        [HttpPost]
        public IActionResult Delete(Tasks ar)
        {
            DbContext.responses.Remove(ar);
            DbContext.SaveChanges();

            return RedirectToAction("Quadrant");
        }
    }
}
