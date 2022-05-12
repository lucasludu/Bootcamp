using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodFactory
{
    class Avion : IVehiculo
    {
        public void Acelerar()
        {
            Console.WriteLine("Empuja el acelerador");
        }

        public void Encender()
        {
            Console.WriteLine("Sigue todo el procedimiento");
        }

        public void Frenar()
        {
            Console.WriteLine("Jala el acelerador");
        }

        public void Girar()
        {
            Console.WriteLine("Mueve el timon de cola");
        }
    }
}
