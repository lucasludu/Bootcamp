using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityRefactor
{
    /*
     * Creamos una clase especializada para la otra responsabilidad
     * Ahora cada clase tiene solo una responsabilidad.
     */

    class Hacienda
    {
        public static double CalcularImpuesto(Empleado empleado)
        {
            return empleado.Sueldo * 0.35;
        }

        public static void PagarImpuesto(Empleado empleado)
        {
            double impuesto = CalcularImpuesto(empleado);
            Console.WriteLine("Se pagó {0} en impuestos por parte de {1}", impuesto, empleado.Nombre);
        }
    }
}
