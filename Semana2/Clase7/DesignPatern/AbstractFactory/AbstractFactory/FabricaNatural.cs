using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class FabricaNatural : IFabrica
    {
        private IProductoLeche leche;
        private IProductosSaborizante sabor;

        public IProductoLeche ObtenProductoLeche { get { return leche; } }
        public IProductosSaborizante ObtenSabor { get { return sabor; } }

        public void CrearProductos()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string seleccion;
            Console.WriteLine("Estamos creando tu bebida.");
            Console.WriteLine("1) Almendra, 2) Coco");
            seleccion = Console.ReadLine();

            if(seleccion == "1")
            {
                leche = new LecheAlmendra();
            }
            else
            {
                leche = new LecheCoco();
            }
            leche.Producir();

            Console.WriteLine("Ahora extraemos el sabor");
            sabor = new VainillaNatural();
            sabor.Obtener();
        }
    }
}
