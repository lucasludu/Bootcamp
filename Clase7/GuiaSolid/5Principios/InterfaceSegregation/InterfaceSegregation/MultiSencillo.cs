using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    class MultiSencillo : IMultifuncional
    {
        public void Imprimir()
        {
            Console.WriteLine("Imprimo tu reporte");
        }

        public void Escanear()
        {
            Console.WriteLine("Estoy escaneando un documento");
        }

        // Estos metodos no los necesitamos
        // Si no lo colocamos hay que poner exeption
        public void Telefono()
        {
            throw new NotImplementedException();
        }

        public void Faxear()
        {
            throw new NotImplementedException();
        }
    }
}
