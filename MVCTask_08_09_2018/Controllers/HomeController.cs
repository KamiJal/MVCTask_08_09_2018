﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTask_08_09_2018.Models;

namespace MVCTask_08_09_2018.Controllers
{
    public class HomeController : Controller
    {
        private ArtsoftDb _context;

        public HomeController()
        {
            _context = new ArtsoftDb();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult ListOfEmployees()
        {
            var employees = _context.Employees.ToList();

            return View(employees);
        }

        public ActionResult AddEmployee()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult EditEmployee(int id)
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}