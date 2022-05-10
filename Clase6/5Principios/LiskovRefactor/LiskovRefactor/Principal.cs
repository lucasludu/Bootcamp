using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovRefactor
{
    abstract class Principal
    {
        protected string mensaje;

        public Principal(string mensaje)
        {
            this.mensaje = mensaje;
        }

        // Lo creamos como abstracto para que cada version lo implemente.
        public abstract void Muestra();
    }
}
