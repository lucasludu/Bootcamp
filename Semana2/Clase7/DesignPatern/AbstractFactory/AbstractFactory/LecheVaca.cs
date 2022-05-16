using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class LecheVaca : IProductoLeche
    {
        public void Producir()
        {
            Console.WriteLine("Ordeñar vaca en la granja");
        }

        public string ObtenDatos()
        {
            return "Leche de vaca, 250 ml";
        }

    }
}
