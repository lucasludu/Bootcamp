using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos el administrador
            AdministrarPrototipo admin = new AdministrarPrototipo();

            // Se obtiene 2 instancias
            Persona pUno = (Persona)admin.ObtenPrototipo("Persona");
            Persona pDos= (Persona)admin.ObtenPrototipo("Persona");

            // Verificamos que tengan los valores del prototipo original
            Console.WriteLine(pUno);
            Console.WriteLine(pDos);
            Console.WriteLine("\n-------\n");

            // Modificamos el estado
            pUno.Nombre = "Ana";
            pDos.Nombre = "Chepe";

            // Verificamos que cada quien tenga su estado
            Console.WriteLine(pUno);
            Console.WriteLine(pDos);
            Console.WriteLine("\n-------\n");

            // Creamos una instancia
            Auto auto = new Auto("Nissan", 25000);

            // Lo colocamos como prototipo
            admin.AdicionarPrototipo("Auto", auto);

            // Obtenemos un objeto de ese prototipo
            Auto auto2 = (Auto)admin.ObtenPrototipo("Auto");

            // Cambiamos el estado
            auto2.Modelo = "Honda";

            // Se verifica que cada uno tenga su estado
            Console.WriteLine(auto);
            Console.WriteLine(auto2);
            Console.WriteLine("\n-------\n");

            // Obtenemos una instancia del costoso
            Valores val = (Valores)admin.ObtenPrototipo("Valores");
            Console.WriteLine(val);

            Console.ReadKey();
        }
    }
}
