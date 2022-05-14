using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationRefactor
{
    class MultiAvanzado : IMultiCompleto
    {
        public void Telefono()
        {
            Console.WriteLine("Te marco a un telefono");
        }

        public void Faxear()
        {
            Console.WriteLine("Envio un fax");
        }

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
