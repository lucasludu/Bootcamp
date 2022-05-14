using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
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

            Console.WriteLine("\n---------------\n");

            Fax miFax = new Fax();
            miFax.Telefono();
            miFax.Faxear();
            miFax.Imprimir();

            Console.WriteLine("\n---------------\n");

            MultiSencillo sencillo = new MultiSencillo();
            sencillo.Escanear();
            sencillo.Imprimir();
            //sencillo.Telefono(); // Lanzará la excepcion

            Console.ReadKey();
        }
    }
}
