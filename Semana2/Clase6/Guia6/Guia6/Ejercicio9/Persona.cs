using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia6.Ejercicio9
{
    public class Persona
    {
        public DateTime fechaNac { get; set; }
        public int Edad()
        {
            DateTime hoy = DateTime.Now;
            int dif = hoy.Year - fechaNac.Year;

            return dif;
        }
        
    }

    public static class Extencion
    {
        public static bool MayorEdad(this Persona persona, int edad)
        {
            if (edad >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
