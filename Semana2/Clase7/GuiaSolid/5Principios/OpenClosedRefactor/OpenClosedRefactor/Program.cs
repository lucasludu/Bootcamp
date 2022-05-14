using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedRefactor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<BaseInventario> productos = new List<BaseInventario>
            {
                new InventarioAlimento(new Producto("Papas", 1, 12.5)),
                new InventarioMedicamento(new Producto("Analgesico", 2, 23.40)),
                new InventarioAlimento(new Producto("Papas", 1, 30)),
                new InventarioAlimento(new Producto("Papas", 1, 25)),
                new InventarioMedicamento(new Producto("Antibiotico", 2, 89)),
                new InventarioMedicamento(new Producto("Antiacido", 2, 43)),
            };
            Tienda miTienda = new Tienda(productos);

            miTienda.CalcularInventario();

            Console.ReadKey();
        }
    }
}
