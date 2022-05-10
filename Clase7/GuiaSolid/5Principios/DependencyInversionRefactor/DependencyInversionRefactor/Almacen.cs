using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionRefactor
{
    class Almacen : IAuditable
    {
        // Ya no hay necesidad de dar acceso a la lista
        private List<Producto> inventario;

        public Almacen()
        {
            inventario = new List<Producto>();
        }

        public void AdicionaProducto(Producto producto)
        {
            inventario.Add(producto);
            Console.WriteLine("Adicionamos {0}", producto.Nombre);
        }

        // Implementacion de la interfaz, hacemos una busqueda flexible
        public IEnumerable<Producto> ObtenProductos(int tipo)
        {
            List<Producto> encontrado = new List<Producto>();

            foreach(Producto p in inventario)
            {
                if(p.Tipo == tipo) 
                { 
                    encontrado.Add(p);
                }
            }
            return encontrado;
        }
    }
}
