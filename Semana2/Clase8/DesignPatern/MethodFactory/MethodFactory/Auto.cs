using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodFactory
{
    class Auto : IVehiculo
    {
        public void Acelerar()
        {
            Console.WriteLine("Pisa el acelerador!!");
        }

        public void Encender()
        {
            Console.WriteLine("Pone la llave y girala");
        }

        public void Frenar()
        {
            Console.WriteLine("Presiona el freno!!");
        }

        public void Girar()
        {
            Console.WriteLine("Gira el volante");
        }
    }
}
