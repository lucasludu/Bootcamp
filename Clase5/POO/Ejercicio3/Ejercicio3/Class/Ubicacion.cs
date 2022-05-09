using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Class
{
    public class Ubicacion
    {
        private double x;
        private double y;

        public double X
        {
            get { return x; }
        }

        public double Y
        {
            get { return Y; }
        }

        public Ubicacion(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return "X: " + x + "\nY: " + y;
        }
    }
}
