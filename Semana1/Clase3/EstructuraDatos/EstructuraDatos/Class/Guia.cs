using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDatos.Class
{
    public class Guia
    {
        private int[] vector;
        /*
         * 1 - Se tiene las notas de 4 parciales tomados a 30 alumnos ordenados en forma creciente
         * por NRO DE ALUMNO. El nro de alumno es un valor entero entre 1 y 12000. Se desea
         * ingresar un NRO DE ALUMNO y buscarlo por medio de la búsqueda dicotómica dentro del
         * arreglo. Si se encuentra, dar el nro de alumno junto con las notas de los 4 parciales; sino
         * exhibir cartel aclaratorio.
         */

        public void Cargar(int numero, int cantidad, int min, int max)
        {
            Random rnd = new Random();
            int[] arreglo = new int[cantidad];
            for (int i = 0; i < arreglo.Length; i++)
            {
                numero = rnd.Next(min, max);
                arreglo[i] = numero;
            }
        }

        public void Imprimir()
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine(vector[i]);
            }
        }

        public void cargarNotasAlumnos()
        {
            int qAlumnos = 30, valAlumnos = 0; ;
            int qNotas = 4, valNotas = 0;
            Random rnd = new Random();

            int[,] alumnoNota = new int[qAlumnos, qNotas];
            int[] nroAlumno = new int[qAlumnos];
            int[] nota = new int[qNotas];


            for(int i = 0; i < 30; i++)
            {
                Cargar(nroAlumno[i], qAlumnos, 1, 12001);
                OrdenarMetodoBurbuja(nroAlumno);
                for (int j = 0; j < 4; j++)
                {
                    Cargar(nota[j], qNotas, 1, 11);
                    alumnoNota[i, j] = nota[j];
                    Console.WriteLine("Alumno[{0},{1}] = {2}", nroAlumno[i], j+1, alumnoNota[i,j]);
                }
                Console.WriteLine();
            }
        }

        public void OrdenarMetodoBurbuja(int[] vector)
        {
            int t;
            for(int i = 1; i < vector.Length; i++)
            {
                for(int j = vector.Length - 1; j >= i; j--)
                {
                    if(vector[j-1] > vector[j])
                    {
                        t = vector[j - 1];
                        vector[j - 1] = vector[j];
                        vector[j] = t;
                    }
                }
            }
        }

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
