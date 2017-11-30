using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CF_Pee.Models
{
    public class MyStudentsContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MyStudentsContext() : base("name=MyStudentsContext")
        {
        }

        public System.Data.Entity.DbSet<CF_Pee.Models.Student> Students { get; set; }

        public System.Data.Entity.DbSet<CF_Pee.Models.Cycle> Cycles { get; set; }

        public System.Data.Entity.DbSet<CF_Pee.Models.Course> Courses { get; set; }

        public System.Data.Entity.DbSet<CF_Pee.Models.Teacher> Teachers { get; set; }

        public System.Data.Entity.DbSet<CF_Pee.Models.Notes> Notes { get; set; }

        public System.Data.Entity.DbSet<CF_Pee.Models.Place> Places { get; set; }
    }
}
