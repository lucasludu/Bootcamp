using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedRefactor
{
    class Tienda
    {
        private List<BaseInventario> productos;

        public Tienda(List<BaseInventario> productos)
        {
            this.productos = productos;
        }

        public void CalcularInventario()
        {
            double total = 0;

            foreach(var producto in productos)
            {
                producto.CalcularProducto();
                Console.WriteLine(producto);
                total += producto.Producto.Precio;
            }
            Console.WriteLine("El total en inventario es {0}", total);
        }
    }
}
