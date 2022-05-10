using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Almacen miALmacen = new Almacen();
            double total = 0;

            miALmacen.AdicionarProducto(new Producto("Tomate", 0, 15.50));
            miALmacen.AdicionarProducto(new Producto("Banana", 0, 30));
            miALmacen.AdicionarProducto(new Producto("Analgesico", 1, 23.80));
            miALmacen.AdicionarProducto(new Producto("Jeans", 2, 450.99));
            miALmacen.AdicionarProducto(new Producto("Manzana", 0, 12.38));
            miALmacen.AdicionarProducto(new Producto("Antiacido", 1, 38.50));
            miALmacen.AdicionarProducto(new Producto("Blusa", 2, 200.88));

            Console.WriteLine("\n---------------\n");

            Auditor miAuditor = new Auditor(miALmacen);
            total = miAuditor.TotalesAlimentos();

            Console.WriteLine("El total de alimentos es: {0}", total);

            Console.ReadKey();
        }
    }
}
