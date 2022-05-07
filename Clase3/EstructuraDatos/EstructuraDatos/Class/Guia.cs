using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDatos.Class
{
    public class Guia
    {
        /*
         * 1 - Se tiene las notas de 4 parciales tomados a 30 alumnos ordenados en forma creciente
         * por NRO DE ALUMNO. El nro de alumno es un valor entero entre 1 y 12000. Se desea
         * ingresar un NRO DE ALUMNO y buscarlo por medio de la búsqueda dicotómica dentro del
         * arreglo. Si se encuentra, dar el nro de alumno junto con las notas de los 4 parciales; sino
         * exhibir cartel aclaratorio.
         */

        /*
         * 7 - Construir una función que sume los elementos de una lista de enteros recursivamente.
         */

        public int sumaRecursiva(int[] numeros, int i)
        {
            int suma = 0;
            if(i < numeros.Length)
            {
                suma += sumaRecursiva(numeros, i + 1);
            }
            return suma;
        }

    }
}
