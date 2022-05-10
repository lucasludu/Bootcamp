using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityRefactor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado("Lucas", "Programador", 23, 18000);
            Console.WriteLine(empleado);
            Console.WriteLine(Hacienda.CalcularImpuesto(empleado));
            Hacienda.PagarImpuesto(empleado);

            Console.ReadKey();
        }
    }
}
