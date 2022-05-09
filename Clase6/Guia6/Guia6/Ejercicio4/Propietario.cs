using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia6.Ejercicio4
{
    public class Propietario
    {
        public string nombre { get; set; }
        public DateTime fechNac { get; set; }

        public override string ToString()
        {
            return "Nombre: " + nombre + "\nFecha de Nacimiento: " + fechNac.Year;
        }
    }
}
