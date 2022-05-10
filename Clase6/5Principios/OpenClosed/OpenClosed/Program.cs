using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Producto> misProductos = new List<Producto>
            {
                new Producto("Papas", 1, 12.5),
                new Producto("Analgesico", 2, 23.40),
                new Producto("Tomate", 1, 1.30),
                new Producto("Manzana", 1, 1.25),
                new Producto("Antibiotico", 2, 2.89),
                new Producto("Antiacido", 2, 2.45),
            };
            Tienda miTienda = new Tienda(misProductos);
            miTienda.CalcularInventario();

            Console.ReadKey();
        }
    }
}
