using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burbuja
{
    internal class Program
    {
        class Burbuja
        {
            private int[] vector;

            public void Cargar()
            {
                Console.WriteLine("Metodo de Burbuja.");
                Console.WriteLine("Longitud del vector: ");
                string linea;
                linea = Console.ReadLine();
                int cantidad;
                cantidad = int.Parse(linea);
                vector = new int[cantidad];
                for(int i = 0; i < vector.Length; i++)
                {
                    Console.WriteLine("Ingrese elementos: " + (i + 1) + ": ");
                    linea = Console.ReadLine();
                    vector[i] = int.Parse(linea);
                }
            }

            public void MetodoBurbuja()
            {
                int t;
                for(int a = 1; a < vector.Length; a++)
                {
                    for(int b = vector.Length - 1; b >= a; b--)
                    {
                        if(vector[b-1] > vector[b])
                        {
                            t = vector[b - 1];
                            vector[b - 1] = vector[b];
                            vector[b] = t;
                        }
                    }
                }
            }

            public void Imprimir()
            {
                Console.WriteLine("Vector ordenado en forma ascendente");
                for(int i = 0; i < vector.Length; i++)
                {
                    Console.Write(vector[i] + " ");
                }
                Console.ReadKey();
            }

        }
        static void Main(string[] args)
        {
            Burbuja pv = new Burbuja();
            pv.Cargar();
            pv.MetodoBurbuja();
            pv.Imprimir();
        }
    }
}
