using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Persona : IPrototipo
    {
        private string nombre;
        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }

        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", nombre, edad); 
        }

        public object Clonar()
        {
            Persona clon = new Persona(nombre, edad);
            return clon;
        }
    }
}
