using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgileCamp.Habitator.Models
{
    public class Habit
    {
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
    }
}