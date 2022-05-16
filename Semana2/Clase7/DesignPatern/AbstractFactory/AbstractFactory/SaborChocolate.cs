using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class SaborChocolate : IProductosSaborizante
    {
        public void Obtener()
        {
            Console.WriteLine("Se produce C7H8N402");
        }

        public string Informacion()
        {
            return "Sabor a chocolate";
        }
    }
}
