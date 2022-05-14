using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Class
{
    public class Estudiante : Persona
    {
        public Estudiante(string nombre) : base(nombre) { }
        public void Estudiar()
        {
            Console.WriteLine("El estudiante {0} está estudiando.", Nombre);
        }
    }
}
