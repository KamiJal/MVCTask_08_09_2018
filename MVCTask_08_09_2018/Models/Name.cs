using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCTask_08_09_2018.Models
{
    public class Name
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Value { get; set; }
    }
}