using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationRefactor
{
    internal class MultiSencillo : IMultiBasico
    {
        public void Escanear()
        {
            Console.WriteLine("Imprimo tu documento");
        }

        public void Imprimir()
        {
            Console.WriteLine("Escaneo tu fotografia");
        }

    }
}
