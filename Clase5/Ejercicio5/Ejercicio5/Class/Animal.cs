using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5.Class
{
    public abstract class Animal
    {
        private string nombre;

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public abstract void Comer();
    }
}
