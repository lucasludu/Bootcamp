using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovRefactor
{
    class Radio : Principal
    {
        public Radio(string mensaje) : base(mensaje)
        {

        }

        public override void Muestra()
        {
            Console.WriteLine("Desde el radio: {0}", mensaje);
        }

    }
}
