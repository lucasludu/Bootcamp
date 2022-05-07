using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guia guia = new Guia();
            int nroEjercicio;

            Console.WriteLine("Ingresar Numero de Ejercicio a Realizar: ");
            nroEjercicio = int.Parse(Console.ReadLine());

            switch (nroEjercicio)
            {
                case 0:
                    Console.WriteLine("Bye!");
                    break;
                case 1:
                    guia.ejercicio1();
                    break;
                case 2:
                    guia.ejercicio2();
                    break;
                case 3:
                    guia.ejercicio3();
                    break;
                case 4:
                    guia.ejercicio4();
                    break;
                case 5:
                    break;
                case 6:
                    guia.ejercicio6();
                    break;
                case 7:
                    Console.WriteLine("Cantidad de segundos a convertir: ");
                    int segundos = int.Parse(Console.ReadLine());
                    guia.ejercicio7(segundos);
                    break;
                case 8:
                    guia.ejercicio8();
                    break;
                case 9:
                    double baseMenor, baseMayor, altura, area;

                    Console.Write("Base Menor: ");
                    baseMenor = double.Parse(Console.ReadLine());

                    Console.Write("Base Mayor: ");
                    baseMayor = double.Parse(Console.ReadLine());

                    Console.Write("Altura: ");
                    altura = double.Parse(Console.ReadLine());

                    area = guia.ejercicio9(baseMenor, baseMayor, altura);
                    Console.WriteLine("El area del trapecio es de: " + area);
                    break;
                case 10:
                    break;
                case 11:
                    guia.ejercicio11();
                    break;
                case 12:
                    break;
                case 13:
                    guia.ejercicio13();
                    break;
                case 14:
                    guia.ejercicio14();
                    break;
                case 15:
                    break;
                case 16:
                    guia.ejercicio16();
                    break;
                default:
                    break;
            }
        }
    }
}
