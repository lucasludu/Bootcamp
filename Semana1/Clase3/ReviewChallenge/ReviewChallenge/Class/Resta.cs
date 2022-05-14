using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewChallenge.Class
{
    public class Resta : Operacion
    {
        private int resultado;

        public Resta(int valor1, int valor2) : base(valor1, valor2)
        {
            this.resultado = valor1 - valor2;
        }

        public override string ToString()
        {
            return "Resultado: " + resultado;
        }
    }
}
