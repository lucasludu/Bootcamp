using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Noticiero miNoticiero = new Noticiero("Hola a todos!");
            miNoticiero.Muestra();

            Radio miRadio = new Radio("Como estan?");
            miRadio.Muestra();

            Console.WriteLine("\n--------------\n");

            // Sustituimos la clase hija y vemos como se comportan
            Noticiero sustitucion = new Radio("Estamos probando");
            sustitucion.Muestra();
        }
    }
}
