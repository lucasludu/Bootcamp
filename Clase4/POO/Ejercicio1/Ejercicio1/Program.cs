using System;
using Ejercicio1.Class;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 3;
            Persona[] persona = new Persona[total];

            for(int i = 0; i < total; i++)
            {
                Console.Write("Ingrese el nombre: ");
                persona[i] = new Persona()
                {
                    
                    Nombre = Console.ReadLine()
                };
            }

            for(int i = 0; i < total; i++)
            {
                Console.WriteLine(persona[i].ToString());
            }



            
            Console.ReadKey();

        }
    }
}
