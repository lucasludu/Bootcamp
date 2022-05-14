using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewChallenge.Class
{
    public abstract class Operacion
    {
        protected int valor1;
        protected int valor2;

        protected Operacion(int valor1, int valor2)
        {
            this.valor1 = valor1;
            this.valor2 = valor2;
        }

        public int Valor1 { get => valor1; set => valor1 = value; }
    }
}
