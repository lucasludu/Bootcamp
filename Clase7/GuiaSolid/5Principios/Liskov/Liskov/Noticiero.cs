using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov
{
    class Noticiero
    {
        protected string mensaje;

        public Noticiero(string mensaje)
        {
            this.mensaje = mensaje;
        }

        // Primera Prueba
        /*
        public void Muestra()
        {
            Console.WriteLine("Desde el noticiero: {0}", mensaje);
        }
        */

        // Segunda Prueba
        public virtual void Muestra()
        {
            Console.WriteLine("Desde el noticiero: {0}", mensaje);
        }
    }
}
