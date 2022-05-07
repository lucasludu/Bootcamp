using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Class
{
    public class Profesor : Persona
    {
        public Profesor(string nombre) : base(nombre) { }
        public void Explicar()
        {
            Console.WriteLine("El profesor {0} esta explicando.", Nombre);
        }
    }
}
