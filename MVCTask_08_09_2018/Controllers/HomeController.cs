using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTask_08_09_2018.Models;
using MVCTask_08_09_2018.ViewModels;

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

        public ActionResult Add()
        {
            var viewModel = new EmployeeFormViewModel
            {
                Departments = _context.Departments.ToList(),
                Sexes = _context.Sexes.ToList(),
                ProgrammingLanguages = _context.ProgrammingLanguages.ToList()
            };

            return View("EmployeeForm", viewModel);
        }

        public ActionResult EditEmployee(int id)
        {


            return View();
        }
    }
}