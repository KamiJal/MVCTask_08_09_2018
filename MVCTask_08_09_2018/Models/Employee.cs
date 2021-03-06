﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MVCTask_08_09_2018.ProjectValidationAttributes;
using MVCTask_08_09_2018.Utility;

namespace MVCTask_08_09_2018.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = ErrorMessages.RequiredField)]
        [StringLength(255, ErrorMessage = ErrorMessages.StringLength255)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = ErrorMessages.RequiredField)]
        [StringLength(255, ErrorMessage = ErrorMessages.StringLength255)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = ErrorMessages.RequiredField)]
        [AgeUnderEighteen]
        public int Age { get; set; }

        [Required(ErrorMessage = ErrorMessages.SelectValue)]
        [DisplayName("Sex")]
        public int SexId { get; set; }

        [Required(ErrorMessage = ErrorMessages.SelectValue)]
        [DisplayName("Department")]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = ErrorMessages.SelectValue)]
        [DisplayName("Programming Language")]
        public int ProgrammingLanguageId { get; set; }

        public Department Department { get; set; }
        public Sex Sex { get; set; }
        public ProgrammingLanguage ProgrammingLanguage { get; set; }
    }
}