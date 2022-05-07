using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Class
{
    public class Profesor : Persona
    {

        public Profesor(int edad) : base(edad)
        {

        }
        public void Explicar()
        {
            Console.WriteLine("Estoy Explicando");
        }
    }
}
