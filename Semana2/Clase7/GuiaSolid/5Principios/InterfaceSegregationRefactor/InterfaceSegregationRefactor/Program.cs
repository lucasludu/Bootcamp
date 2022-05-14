using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationRefactor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MultiAvanzado avanzado = new MultiAvanzado();
            avanzado.Escanear();
            avanzado.Faxear();
            avanzado.Imprimir();
            avanzado.Telefono();

            Console.WriteLine("\n----------------\n");

            Fax fax = new Fax();
            fax.Telefono();
            fax.Faxear();

            Console.WriteLine("\n----------------\n");

            MultiSencillo sencillo = new MultiSencillo();
            sencillo.Escanear();
            sencillo.Imprimir();

            Console.ReadKey();
        }
    }
}
