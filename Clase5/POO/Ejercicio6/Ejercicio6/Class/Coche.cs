using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ejercicio6.Interface;

namespace Ejercicio6.Class
{
    public class Coche : IVehiculo
    {

        private int nafta;

        public Coche()
        {

        }

        public Coche(int nafta)
        {
            Nafta = nafta;
        }

        public int Nafta { get => nafta; set => nafta = value; }

        public override string ToString()
        {
            return "Nafta: " + nafta;
        }

        public bool cargarNafta(int qGas)
        {
            Nafta += qGas;
            return true;
        }

        public void Conducir()
        {
            if(Nafta > 0)
            {
                Console.WriteLine("Estoy Conduciendo.");
            }
            else
            {
                Console.WriteLine("No hay nafta");
            }
        }
    }
}
