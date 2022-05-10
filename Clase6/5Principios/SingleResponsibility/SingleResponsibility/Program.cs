using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado("Juan", "Programador", 23, 18000);
            Console.WriteLine(empleado);
            empleado.PagarImpuesto();

            Console.ReadKey();
        }
    }
}
