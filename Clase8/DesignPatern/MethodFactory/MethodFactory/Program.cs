using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dato;
            int dinero;
            IVehiculo vehiculo;

            Console.WriteLine("Cuanto dinero tienes para tu vehiculo?");
            dato = Console.ReadLine();
            dinero = Convert.ToInt32(dato);

            // Obtenemos el vehiculo de la fabrica
            vehiculo = Creador.MetodoFabrica(dinero);

            vehiculo.Encender();
            vehiculo.Acelerar();
            vehiculo.Frenar();
            vehiculo.Girar();

            Console.ReadKey();
        }
    }
}
