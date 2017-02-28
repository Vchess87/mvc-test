using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class TestViewModel
    {
        [Required]
        [MinLength(3)]
        public string Name { get; set; }
        
        [Range(2, 10, ErrorMessage = "Must be between 2 and 10")]
        public int Age { get; set; }

        public bool IsStudent { get; set; }
    }
}