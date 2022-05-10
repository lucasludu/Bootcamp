using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    class Almacen
    {
        private List<Producto> inventario;

        /*
         * Nos vemos forzado a crear la propiedad para que se pueda contar el inventario
         * Al ser una propiedad de tipo List forzamos a Auditor a trabajar con List
         */

        public List<Producto> Inventario { get => inventario; set => inventario = value; }

        public Almacen()
        {
            inventario = new List<Producto>();
        }

        public void AdicionarProducto(Producto producto)
        {
            inventario.Add(producto);
            Console.WriteLine("Adicionamos {0}", producto.Nombre);
        }

    }
}
