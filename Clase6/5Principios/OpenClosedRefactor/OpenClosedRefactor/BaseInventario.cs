using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedRefactor
{
    abstract class BaseInventario
    {
        protected Producto producto;

        public Producto Producto { get => producto; set => producto = value; }

        public BaseInventario(Producto producto)
        {
            this.producto = producto;
        }

        public override string ToString()
        {
            return producto.ToString();
        }

        public abstract double CalcularProducto();
    }
}
