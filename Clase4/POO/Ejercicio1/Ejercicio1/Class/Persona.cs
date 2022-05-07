using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Class
{
    internal class Persona
    {
        private string nombre;
        public Persona() { }
        public Persona (string nombre)
        {
            this.nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }

        public override string ToString()
        {
            return "Hola " + nombre + " :D\n";
        }

    }
}
