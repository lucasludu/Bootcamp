using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    class Producto
    {
        private string nombre;
        private int categoria;
        private double precio;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Categoria { get => categoria; set => categoria = value; }
        public double Precio { get => precio; set => precio = value; }

        public Producto(string nombre, int categoria, double precio)
        {
            this.nombre = nombre;
            this.categoria = categoria;
            this.precio = precio;
        }

        public override string ToString()
        {
            return String.Format("El producto {0} cuesta {1}", nombre, precio);
        }

    }
}
