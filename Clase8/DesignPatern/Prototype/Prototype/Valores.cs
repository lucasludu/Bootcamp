using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    // Simulamos que esta es una clase que tiene un constructor costoso
    class Valores : IPrototipo
    {
        private double sumatoria;
        private int m = 1;

        public int M { get => m; set => m = value; }
        public double Sumatoria { get => sumatoria; set => sumatoria = value; }

        public Valores() { }

        // Este es el constructor costoso
        public Valores(int m)
        {
            this.m = m;
            int n = 0;
            for(n = 0; n < 90; n++)
            {
                sumatoria += Math.Sin(n * 0.0175);
            }
        }

        public override string ToString()
        {
            return String.Format("{0}", sumatoria * m);
        }

        public object Clonar()
        {
            Valores clon = new Valores();
            clon.M = m;
            clon.Sumatoria = sumatoria;

            return clon;
        }
    }
}
