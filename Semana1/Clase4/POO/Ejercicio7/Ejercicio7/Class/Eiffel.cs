using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7.Class
{
    public class Eiffel
    {
        List<string> elementos = new List<string>();

        /**
        * Inserción, que añade un elemento a la lista en el orden adecuado. 
        */

        public void Insercion(string elemento)
        {
            elementos.Add(elemento);
        }

        /**
        * Elemento en la posición iésima, que devuelve el elemento que se encuentra en esta posición, 
        * si es que esta posición está ocupada.
        */

        public string Elemento(int posicion)
        {
            if(elementos[posicion] != null)
            {
                return elementos[posicion];
            } 
            else
            {
                return null;
            }
        }

        /**
        * Elementos que indica el número de posiciones ocupadas en este momento.
        */

        public int Elementos()
        {
            int i = 0;
            while(i < elementos.Count)
            {
                i++;
            }
            return i;
        }

        /**
        * Poda, que elimina el primer elemento de la lista.
        */

        public void Poda()
        {
            if (elementos.Count > 0)
            {
                elementos.RemoveAt(0);
            }
        }

    }
}
