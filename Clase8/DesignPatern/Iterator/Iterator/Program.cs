using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contenedora datos = new Contenedora();

            foreach(int valor in datos)
            {
                Console.WriteLine(valor);
            }

            Console.ReadKey();
        }
    }
}
 