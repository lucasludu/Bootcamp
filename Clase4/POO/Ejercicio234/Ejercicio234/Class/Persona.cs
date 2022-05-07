using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio234.Class
{
    public class Persona
    {
        private string nombre;
        private int edad;
        private string dni;

        public Persona()
        {

        }

        public Persona(string nombre, int edad, string dni)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Dni = dni;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Dni { get => dni; set => dni = value; }

        public override string ToString()
        {
            return "Nombre: " + nombre +
                   "\nEdad: " + edad +
                   "\nDni: " + dni;
        }

        public bool esMayorEdad()
        {
            if(this.edad >= 18) { return true; } else { return false; }
        }

    }
}
