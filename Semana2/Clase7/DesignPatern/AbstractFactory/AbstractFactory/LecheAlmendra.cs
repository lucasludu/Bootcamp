using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class LecheAlmendra : IProductoLeche
    {
        public void Producir()
        {
            Console.WriteLine("Procesar las almendras");
        }

        public string ObtenDatos()
        {
            return "Leche organica de almendra, 250 ml";
        }
    }
}
