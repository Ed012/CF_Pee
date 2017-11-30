using CF_Pee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CF_Pee.Services
{
    public class TeacherIsEmptyService
    {
        public List<string> Errores { get; private set; }
        public bool IsValid(Teacher teacher)
        {
            Errores = new List<string>();

            var valid = true;
            if (string.IsNullOrWhiteSpace(teacher.Name))
            {
                Errores.Add("Se requiere el nombre del docente");
                valid = false;
            }
            return valid;
        }
    }
}