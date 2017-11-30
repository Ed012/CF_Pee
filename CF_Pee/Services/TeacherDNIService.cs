using CF_Pee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CF_Pee.Services
{
    public class TeacherDNIService
    {
        public List<string> Errores { get; private set; }
        public bool IsValid(Teacher teacher)
        {
            Errores = new List<string>();

            var valid = true;
            if (teacher.DNI < 0)
            {
                Errores.Add("Se requiere que el DNI del docente ");
                valid = false;
            }
            return valid;
        }
    }
}