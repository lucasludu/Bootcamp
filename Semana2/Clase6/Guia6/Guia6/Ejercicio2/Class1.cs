using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia6.Ejercicio2
{
    partial class Vehiculo
    {
        public void Arrancar()
        {
            if(estadoMotor = true)
            {
                Console.Write("El vehiculo está encendido.");
            } else
            {
                Console.Write("El vehiculo está apagado.");
            }
        }

        public void Frenar()
        {
            Console.Write("El vehiculo está frenando.");
        }

        public void Acelerar()
        {
            Console.Write("El vehiculo está acelerando.");
        }

        public void Apagar()
        {
            Console.Write("El vehiculo está apagado.");
        }
    }
}
