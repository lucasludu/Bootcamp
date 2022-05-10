using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    class Tienda
    {
        private List<Producto> productos;

        public Tienda(List<Producto> productos)
        {
            this.productos = productos;
        }

        public void CalcularInventario()
        {
            double total = 0;
            /*
            foreach(Producto producto in productos)
            {
                Console.WriteLine(producto);
                total += producto.Precio;
            }
            */
            // Cambio de requerimiento
            foreach (Producto producto in productos)
            {
                if(producto.Categoria == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    producto.Precio *= 0.8;
                    Console.WriteLine(producto);
                    total += producto.Precio;
                }
                if(producto.Categoria == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    producto.Precio *= 1.2;
                    Console.WriteLine(producto);
                    total += producto.Precio;
                }
            }
            Console.WriteLine("El total del inventario es de {0}", total);
        }
    }
}
