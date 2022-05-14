using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quicksort
{
    internal class Program
    {
        public class Quicksort
        {
            int h;
            int[] vector;

            public void Llenar(int n)
            {
                h = n;
                vector = new int[h];
                for(int i = 0; i < h; i++)
                {
                    Console.WriteLine("Ingrese valor {0}: ", (i + 1));
                    vector[i] = Int32.Parse(Console.ReadLine());
                }
                QuickSort(vector, 0, h - 1);
                mostrar();
            }

            public void QuickSort(int[] vector, int primero, int ultimo)
            {
                int i, j, central;
                double pivote;

                central = (primero + ultimo) / 2;
                pivote = vector[central];
                i = primero;
                j = ultimo;

                do
                {
                    while (vector[i] < pivote) i++;
                    while (vector[j] < pivote) j++;
                    if(i <= j)
                    {
                        int temp;
                        temp = vector[i];
                        vector[i] = vector[j];
                        vector[j] = temp;
                        i++;
                        j--;
                    }
                } while (i <= j);

                if(primero < j)
                {
                    QuickSort(vector, primero, j);
                }
                if(i < ultimo)
                {
                    QuickSort(vector, i, ultimo);
                }

            }

            public void mostrar()
            {
                Console.WriteLine("Vector ordenados en forma ascendente.");
                for(int i = 0; i < h; i++)
                {
                    Console.Write("{0} ", vector[i]);
                }
                Console.ReadLine();
            }
        }

        /* 
         public void busqueda(int num)
        {
            int l = 0, h = 9;
            int m = 0;
            bool found = false;

            while (l <= h && found == false)
            {
                m = (l + h) / 2;
                if (vector[m] == num)
                    found = true;
                if (vector[m] > num)
                    h = m - 1;
                else
                    l = m + 1;
            }
            if (found == false)
            { Console.Write("\nEl elemento 
          if (found == false)
            { Console.Write("\nEl elemento {0} no esta en el arreglo", num); }
            else
            { Console.Write("\nEl elemento {0} esta en la posicion: {1}", num, m + 1); }
        }
         */

        static void Main(string[] args)
        {
            Quicksort b = new Quicksort();
            int n;
            Console.WriteLine("Metodo de Quick Sort");
            Console.Write("Cuantos longitud del vector: ");
            n = Int32.Parse(Console.ReadLine());
            b.Llenar(n);
        }
    }
}
