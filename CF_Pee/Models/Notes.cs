using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CF_Pee.Models
{
    public class Notes
    {
        [Key]
        public int IdNote { get; set; }
        public int First_Test { get; set; }
        public int Last_Test { get; set; }

        public int IdCourse { get; set; }
        public Course Course { get; set; }

        public int IdStudent { get; set; }
        public Student Student { get; set; }
    }
}