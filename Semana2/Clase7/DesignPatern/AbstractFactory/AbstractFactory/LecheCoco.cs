using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class LecheCoco : IProductoLeche
    {
        public void Producir()
        {
            Console.WriteLine("Buscamos los cocos");
        }

        public string ObtenDatos()
        {
            return "Leche de coco natural, 250 ml";
        }
    }
}
