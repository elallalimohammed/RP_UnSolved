using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRazorPages.Models
{
    public class Student
    {      
        public string Id { get; set; }

        [Required, MaxLength(30)]
        public string Name { get; set; }

        [Required]
        public string ImagePath { get; set; }
        public Section  Section{ get; set; }

    }
}
