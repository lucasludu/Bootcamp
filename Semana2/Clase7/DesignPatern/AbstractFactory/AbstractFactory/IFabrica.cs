using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    interface IFabrica
    {
        void CrearProductos();
        IProductoLeche ObtenProductoLeche { get; }
        IProductosSaborizante ObtenSabor { get; }
    }
}
