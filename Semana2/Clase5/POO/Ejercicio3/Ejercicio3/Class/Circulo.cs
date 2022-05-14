using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Class
{
    public class Circulo
    {
        public double radio { get; set; }
        public Ubicacion c { get; set; }

        public Circulo(double radio)
        {
            this.radio = radio;
            this.c = new Ubicacion(0, 0);
        }
    }
}
