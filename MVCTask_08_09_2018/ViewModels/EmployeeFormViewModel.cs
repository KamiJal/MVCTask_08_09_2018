using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCTask_08_09_2018.Models;

namespace MVCTask_08_09_2018.ViewModels
{
    public class EmployeeFormViewModel
    {
        public string Title { get; set; }
        public string SubmitName { get; set; }

        public Employee Employee { get; set; }
        public IEnumerable<Department> Departments { get; set; }
        public IEnumerable<Sex> Sexes { get; set; }
        public IEnumerable<ProgrammingLanguage> ProgrammingLanguages { get; set; }
    }
}