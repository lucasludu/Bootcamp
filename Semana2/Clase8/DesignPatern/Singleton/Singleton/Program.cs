using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // No se puede obtener la instancia directamente
            // Singleton single = new Singleton();

            // Obtenemos la instacia, se crea por primera vez
            Singleton uno = Singleton.ObtenInstancia();

            // Hacemos algo con la instancia
            uno.PonerDatos("Ana", 27);
            uno.AlgunProceso();

            Console.WriteLine(uno);
            Console.WriteLine("\n-------------\n");

            // Obtenemos la instancia
            Singleton dos = Singleton.ObtenInstancia();

            // Comprobamos que es la misma instancia.
            // Si lo es, tendra el mismo estado
            Console.WriteLine(dos);

            Console.ReadKey();
        }
    }
}
