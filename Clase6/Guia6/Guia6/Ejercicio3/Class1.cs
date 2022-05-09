using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia6.Ejercicio3
{
    partial class Persona
    {
        public int Edad()
        {
            DateTime hoy = DateTime.Now;
            var edad = (int)DateTime.Now.Year - fechNac.Year;
            return edad;
        }
    }
}
