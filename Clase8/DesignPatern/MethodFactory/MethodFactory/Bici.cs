using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodFactory
{
    class Bici : IVehiculo
    {
        public void Acelerar()
        {
            Console.WriteLine("Pedalea fuerte para acelerar");
        }

        public void Encender()
        {
            Console.WriteLine("Las bicis no necesitan encendido");
        }

        public void Frenar()
        {
            Console.WriteLine("Presiona el freno de atras primero");
        }

        public void Girar()
        {
            Console.WriteLine("Usa el manubrio");
        }
    }
}
