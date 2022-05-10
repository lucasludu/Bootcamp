using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovRefactor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Principal miNoticiero = new Noticiero("Hola a todos!");
            miNoticiero.Muestra();

            Principal miRadio = new Radio("Como estan?");
            miRadio.Muestra();

            Console.ReadKey();

        }
    }
}
