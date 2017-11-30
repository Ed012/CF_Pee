using CF_Pee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CF_Pee.Services
{
    public class StudentService
    {
        public List<string> Errores { get; private set; }
        public bool IsValid(Student student)
        {
            Errores = new List<string>();

            var valid = true;
            if (string.IsNullOrWhiteSpace(student.Name))
            {
                Errores.Add("Se requiere el nombre del estudiante");
                valid = false;
            }
            return valid;
        }
    }
}