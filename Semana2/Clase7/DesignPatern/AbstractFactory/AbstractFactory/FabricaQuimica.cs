using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class FabricaQuimica : IFabrica
    {
        private IProductoLeche leche;
        private IProductosSaborizante sabor;

        public IProductoLeche ObtenProductoLeche { get { return leche; } }
        public IProductosSaborizante ObtenSabor { get { return sabor; } }

        public void CrearProductos()
        {
            Console.WriteLine("Estamos produciendo tu malteada");
            leche = new LecheVaca();
            sabor = new SaborChocolate();
        }

    }
}
