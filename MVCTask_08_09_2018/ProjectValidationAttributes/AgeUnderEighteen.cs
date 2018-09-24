using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MVCTask_08_09_2018.Models;
using MVCTask_08_09_2018.Utility;

namespace MVCTask_08_09_2018.ProjectValidationAttributes
{
    public class AgeUnderEighteen : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var employee = (Employee) validationContext.ObjectInstance;

            return (employee.Age >= 18) ? ValidationResult.Success : new ValidationResult(ErrorMessages.EmployeeEighteen);
        }
    }
}