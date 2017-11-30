using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CF_Pee.Models
{
    public class Course
    {
        [Key]
        public int IdCourse { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int IdCycle { get; set; }
        public Cycle Cycle { get; set; }
    }
}