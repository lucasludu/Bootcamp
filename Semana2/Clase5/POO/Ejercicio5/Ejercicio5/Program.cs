using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ejercicio5.Class;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perro perrito = new Perro();

            Console.Write("Ingresar Nombre al perro: ");
            perrito.SetNombre(Console.ReadLine());
            Console.WriteLine(perrito.GetNombre());
            perrito.Comer();

            Console.ReadKey();
        }
    }
}
