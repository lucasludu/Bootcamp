using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewChallenge.Class
{
    public class Documento
    {
        private string tipo;
        private int numero;

        public Documento(string tipo, int numero)
        {
            this.tipo = tipo;
            this.numero = numero;
        }

        public string Tipo { get => tipo; set => tipo = value; }
        public int Numero { get => numero; set => numero = value; }

        public override string ToString()
        {
            return " " + tipo + " - " + numero;
        }
    }
}
