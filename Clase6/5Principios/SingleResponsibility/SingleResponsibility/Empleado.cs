using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    class Empleado
    {
        private string nombre;
        private string puesto;
        private int edad;
        private double sueldo;

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
        
        /*
         * Aca van otros métodos propios de empleado
         * tales como AsignarHorario, ProyectoActual
         * 
         * Ahora colocamos algo que no es responsabilidad del empleado
         * Hay 2 razones para cambiar la clase
         *  Cuando cambia algo del empleado y
         *  Cuando cambia algo relacionado con los impuestos
         */

        public double CalcularImpuesto()
        {
            return sueldo * 0.35;
        }

        public void PagarImpuesto()
        {
            double impuesto = CalcularImpuesto();
            Console.WriteLine("Se pago {0} en impuestos por parte de {1}", impuesto, nombre);
        }
    }
}
