using System;
using System.Collections;
using System.Collections.Generic;

namespace ReviewChallenge
{
    class Program
    {
                        /***********
                         *  ARREGLO
                         ***********/

        static void cargarArregloRandom(int[] array, int dim)
        {
            Random rnd = new Random();
            for(int i = 0; i < dim; i++)
            {
                array[i] = rnd.Next(1, 11);
            }
        }

        static void muestraArreglo(int[] array) 
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write("[ " + i + " ]: " + array[i] + "\n");
            }
        }

        static int sumaArregloRecursivo(int[] array, int dim, int i)
        {
            int suma = 0;
            if(i < dim)
            {
                suma = array[i] + sumaArregloRecursivo(array, dim, i+1);
            }
            return suma;
        }

                        /***********
                         *  PILA
                         ***********/

        static Stack cargaPila(int q)
        {
            Stack stack = new Stack();
            int number = 0;
            try { 
                for(int i = 0; i < q; i++)
                {
                    Console.WriteLine("Ingrese un numero: ");
                    number = int.Parse(Console.ReadLine());
                    stack.Push((int)number);
                }
            } 
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return stack;
        }

        static void mostrarPila(Stack pila)
        {
            Stack aux = pila;
            int cantidadPila = aux.Count;
            for (int i = 0; i < cantidadPila; i++)
            {
                int muestra = (int)aux.Pop();
                Console.WriteLine("| " + muestra + " |");
                Console.WriteLine("-----");
            }
        }


                        /***********
                         *  COLA
                         ***********/

        static Queue cargarCola(int q)
        {
            Queue cola = new Queue();
            try
            {
                Console.WriteLine("Ingrese numeros a la Cola: ");
                for(int i = 0; i < q; i++)
                {
                    Console.Write("Numero " + (i+1) + ": ");
                    cola.Enqueue(double.Parse(Console.ReadLine()));
                }
            } catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return cola;
        }

        static void muestraCola(Queue queue) 
        { 
            Queue colaAux = queue;
            int cantidadCola = colaAux.Count;
            for(int i = 0; i <= cantidadCola; i++)
            {
                double muestra = (double)colaAux.Dequeue();
                Console.Write(muestra + " ");
            }
        }


        static void Main(string[] args)
        {
            int dim;
            int nroEjercicio = 0;
            Console.WriteLine("Ingrese el numero de ejercicio: ");
            nroEjercicio = int.Parse(Console.ReadLine());
            do
            {
                Console.Clear();
                switch(nroEjercicio)
                {
                    case 0:
                        break;
                    case 1:
                        Console.WriteLine("Ingrese la cantidad a cargar: ");
                        dim = int.Parse(Console.ReadLine());
                        int[] arreglo = new int[dim];
                        cargarArregloRandom((int[])arreglo, dim);

                        Console.WriteLine("\nMuestro Arreglo");
                        muestraArreglo(arreglo);

                        Console.WriteLine("\nSuma Arreglo Recursivo");
                        int suma = sumaArregloRecursivo(arreglo, dim, 0);
                        Console.WriteLine(suma);
                        Console.ReadKey();
                        break;
                    case 2:
                        Stack stack = new Stack();
                        Console.WriteLine("Ingrese la cantidad a cargar: ");
                        dim = int.Parse(Console.ReadLine());
                        stack = cargaPila(dim);

                        Console.WriteLine("\nMuestra Pila");
                        mostrarPila(stack);
                        Console.ReadKey();
                        break;
                    case 3:
                        Queue queue = new Queue();
                        Console.WriteLine("Ingrese la cantidad de Elementos a ingresar en la cola: ");
                        dim = int.Parse(Console.ReadLine());
                        queue = cargarCola(dim);

                        Console.WriteLine("\nMuestra Cola: ");
                        muestraCola(queue);
                        Console.ReadKey();
                        break;
                }
            } while (nroEjercicio != 0);
        }
    }
}
