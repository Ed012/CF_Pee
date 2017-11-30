using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CF_Pee.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Grade { get; set; }
        public string Place_Studies { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
    }
}