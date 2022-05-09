using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia6.Ejercicio4
{
    partial class CuentaCorriente
    {
        private string moneda;
        private Propietario propietario;
        private double saldo;

        public CuentaCorriente(string moneda, Propietario propietario, double saldo)
        {
            this.moneda = moneda;
            this.propietario = propietario;
            this.saldo = saldo;
        }
    }
}
