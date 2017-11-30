using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CF_Pee.Models
{
    public class Cycle
    {
        [Key]
        public int IdCycle { get; set; }
        public string Name { get; set; }
        public string Period { get; set; }

        public List<Course> Courses { get; set; }
    }
}