using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Class
{
    public class Persona
    {
        private int edad;

        public Persona()
        {

        }

        public Persona(int edad)
        {
            this.edad = edad;
        }

        public int Edad { get => edad; set => edad = value; }

        public void Saludar()
        {
            Console.WriteLine("Hola como andas?");
        }


    }
}
