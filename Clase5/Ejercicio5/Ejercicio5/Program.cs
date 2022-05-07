using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ejercicio5.Class;

namespace Ejercicio5
{
    /* 
     * Crea un programa en C# que implemente una clase abstracta Animal que tenga una propiedad Nombre de tipo texto y tres métodos SetNombre(string nombre), 
     * GetNombre y Comer. El método Comer será un método abstracto de tipo void.
     * Además deberá crear una clase Perro que implemente la clase anterior Animal y el método Comer que diga que el perro está Comiendo.
     * Para probar el programa solicite un nombre de perro al usuario y cree un nuevo objeto de tipo Perro desde el Main del programa, 
     * asigne el nombre al objeto Perro y luego ejecute los métodos GetNombre y Comer.
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            Perro perrito = new Perro();

            Console.Write("Ingresar Nombre al perro: ");
            perrito.SetNombre(Console.ReadLine());
            Console.WriteLine(perrito.GetNombre());
            perrito.Comer();
        }
    }
}
