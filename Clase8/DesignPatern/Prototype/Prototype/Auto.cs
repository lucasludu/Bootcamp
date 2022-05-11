using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Auto : IPrototipo
    {
        private string modelo;
        private int costo;

        public string Modelo { get => modelo; set => modelo = value; }

        public Auto(string modelo, int costo)
        {
            this.modelo = modelo;
            this.costo = costo;
        }

        public override string ToString()
        {
            return String.Format("Auto: {0}, {1}", modelo, costo);
        }

        public object Clonar()
        {
            Auto clon = new Auto(modelo, costo);
            return clon;
        }
    }
}
