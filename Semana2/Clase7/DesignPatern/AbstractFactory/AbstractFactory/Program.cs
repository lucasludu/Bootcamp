using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFabrica miFabrica = new FabricaQuimica();

            miFabrica.CrearProductos();

            IProductoLeche miLeche = miFabrica.ObtenProductoLeche;
            IProductosSaborizante miSabor = miFabrica.ObtenSabor;

            miLeche.Producir();
            miSabor.Obtener();

            Console.WriteLine("Mi malteada es de {0} y {1}", miLeche.ObtenDatos(), miSabor.Informacion());
            Console.WriteLine("\n------------\n");

            miFabrica = new FabricaNatural();

            miFabrica.CrearProductos();

            miLeche = miFabrica.ObtenProductoLeche;
            miSabor = miFabrica.ObtenSabor;

            Console.WriteLine("Mi malteada es de {0} y {1}", miLeche.ObtenDatos(), miSabor.Informacion());

            Console.ReadKey();
        }
    }
}
