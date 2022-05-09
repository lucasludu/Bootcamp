using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia6.Ejercicio1
{
    partial class Rectangulo
    {
        public int RetornarSuperficie()
        {
            int sup = lado1 * lado2;
            return sup;
        }

        public int RetornarPerimetro()
        {
            int per = 2 * (lado1 + lado2);
            return per;
        }
    }
}
