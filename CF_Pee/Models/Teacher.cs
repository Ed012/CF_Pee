using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CF_Pee.Models
{
    public class Teacher
    {
        [Key]
        public int IdTeacher { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
        public int DNI { get; set; }

    }
}