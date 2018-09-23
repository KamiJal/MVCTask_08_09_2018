using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCTask_08_09_2018.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [StringLength(255)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [StringLength(255)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public int Age { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [DisplayName("Sex")]
        public int SexId { get; set; }
        public Sex Sex { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [DisplayName("Department")]
        public int DepartmentId { get; set; }

        public Department Department { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [DisplayName("Programming Language")]
        public int ProgrammingLanguageId { get; set; }

        public ProgrammingLanguage ProgrammingLanguage { get; set; }
    }
}