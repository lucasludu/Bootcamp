using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov
{
    class Radio : Noticiero
    {
        public Radio(string mensaje) : base(mensaje)
        {

        }

        // Primera Prueba
        /*
        public new void Muestra()
        {
            Console.WriteLine("Desde el radio: {0}", mensaje);
        }
        */

        // Segunda Prueba
        public override void Muestra()
        {
            Console.WriteLine("Desde el radio: {0}", mensaje);
        }

    }
}
