using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Class
{
    internal abstract class Forma
    {
        public Ubicacion c { get; set; }

        public abstract double area();
        public abstract double perimetro();

    }
}
