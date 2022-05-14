using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia6.Ejercicio4
{
    partial class CuentaCorriente
    {
        public string GetMoneda()
        {
            return moneda;
        }

        public Propietario GetPropietario()
        {
            return propietario;
        }

        public double GetSaldo()
        {
            return saldo;
        }
    }
}
