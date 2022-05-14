using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Class
{
    public class Estudiante : Persona
    {
        public void Estudiar()
        {
            Console.WriteLine("Estoy Estudiando");
        }

        public Estudiante(int edad) : base(edad)
        {

        }

        public void verEdad()
        {
            Console.WriteLine("Edad: {0}", Edad);
        }
    }
}
