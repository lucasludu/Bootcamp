using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityRefactor
{
    // Hacemos refactor de empleado para dejarla solamente con una responsabilidad
    class Empleado
    {
        private string nombre;
        private string puesto;
        private int edad;
        private double sueldo;

        public string Nombre { get => nombre; set => nombre = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }

        public Empleado(string nombre, string puesto, int edad, double sueldo)
        {
            this.nombre = nombre;
            this.puesto = puesto;
            this.edad = edad;
            this.sueldo = sueldo;
        }

        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}, {3}", nombre, puesto, edad, sueldo);
        }
    }
}
