using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Proxy.ISujeto miProxy = new Proxy.ProxySencillo();

            // No podemos acceder a la clase
            //Proxy.Cocina miCocina = new Proxy.Cocina();
            /*
            miProxy.Peticion(1);
            Console.WriteLine("\n----------\n");

            miProxy.Peticion(2);
            Console.WriteLine("\n----------\n");
            */
            Proxy.ISujeto miProxyS = new Proxy.ProxySeguro();

            miProxyS.Peticion(1);
            Console.WriteLine("\n----------\n");
            miProxyS.Peticion(2);

            Console.ReadKey();
        }
    }
}
