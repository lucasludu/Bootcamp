using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia6.Ejercicio12
{
    public class Moneda
    {
        public double numero { get; set; }
    }
    public static class Extencion
    {
        public static double Centavos(this Moneda moneda, double numero)
        {
            double centavos = numero - ((int)moneda.numero);
            return centavos;
        }

        public static int Entero(this Moneda moneda)
        {
            int numero = Convert.ToInt32(moneda.numero);
            return numero;
        }
    }
}
