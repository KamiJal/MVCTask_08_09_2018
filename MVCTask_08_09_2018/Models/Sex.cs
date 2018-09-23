using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCTask_08_09_2018.Models
{
    public class Sex
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Sex")]
        public string Type { get; set; }
    }
}