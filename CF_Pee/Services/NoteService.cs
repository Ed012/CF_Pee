using CF_Pee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CF_Pee.Services
{
    public class NoteService
    {
        public List<string> Errores { get; private set; }
        public bool IsValid(Notes note)
        {
            Errores = new List<string>();

            var valid = true;
            if (note.First_Test < 0)
            {
                Errores.Add("Se requiere una nota mayor a 0 ");
                valid = false;
            }
            return valid;
        }
    }
}