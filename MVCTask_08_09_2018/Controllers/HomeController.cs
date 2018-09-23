using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Net;
using System.Web.Services;
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
            var employees = _context.Employees
                .Include(e => e.Sex)
                .Include(e => e.Department)
                .Include(e => e.ProgrammingLanguage).ToList();

            return View(employees);
        }


        // GET: /add
        public ActionResult Add()
        {
            var viewModel = new EmployeeFormViewModel
            {
                Title = "Add New Employee",
                SubmitName = "Add",
                Departments = _context.Departments.ToList(),
                Sexes = _context.Sexes.ToList(),
                ProgrammingLanguages = _context.ProgrammingLanguages.ToList()
            };

            return View("EmployeeForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new EmployeeFormViewModel
                {
                    Employee = employee,
                    Departments = _context.Departments.ToList(),
                    Sexes = _context.Sexes.ToList(),
                    ProgrammingLanguages = _context.ProgrammingLanguages.ToList()
                };

                return View("EmployeeForm", viewModel);
            }

            if (employee.Id == 0)
            {
                _context.Employees.Add(employee);
            }
            else
            {
                var employeeInDb = _context.Employees.Single(e => e.Id == employee.Id);

                employeeInDb.FirstName = employee.FirstName;
                employeeInDb.LastName = employee.LastName;
                employeeInDb.Age = employee.Age;
                employeeInDb.SexId = employee.SexId;
                employeeInDb.DepartmentId = employee.DepartmentId;
                employeeInDb.ProgrammingLanguageId = employee.ProgrammingLanguageId;
            }

            try
            {
                _context.SaveChanges();
            }
            catch (Exception)
            {
            }

            return RedirectToAction("ListOfEmployees");
        }

        public ActionResult Edit(int id)
        {
            var employee = _context.Employees.SingleOrDefault(e => e.Id == id);

            if (employee == null)
                return HttpNotFound();

            var viewModel = new EmployeeFormViewModel
            {
                Title = "Change Employee Data",
                SubmitName = "Save",
                Employee = employee,
                Departments = _context.Departments.ToList(),
                Sexes = _context.Sexes.ToList(),
                ProgrammingLanguages = _context.ProgrammingLanguages.ToList()
            };

            return View("EmployeeForm", viewModel);
        }

        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            var employee = _context.Employees.SingleOrDefault(e => e.Id == id);

            if (employee == null)
                return HttpNotFound();

            _context.Employees.Remove(employee);

            try
            {
                _context.SaveChanges();
            }
            catch (Exception)
            {
            }


            return RedirectToAction("ListOfEmployees");
        }


        public ActionResult AutoComplete()
        {
            return View();
        }


        public ActionResult NameBase()
        {
            var names = new[] {"ASD", "das", "a123"};

            return Json(names.ToList(), JsonRequestBehavior.AllowGet);
        }

    }
}