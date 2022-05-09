using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
using Guia6.Ejercicio1;
using Guia6.Ejercicio2;
using Guia6.Ejercicio3;
using Guia6.Ejercicio4;
using Guia6.Ejercicio5;
using Guia6.Ejercicio9;
*/

using Guia6.Ejercicio12;

namespace Guia6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Persona persona = new Persona();
            persona.fechaNac = new DateTime(1992, 12, 02);

            int edad = persona.Edad();
            Console.WriteLine("Edad: {0}", edad);

            bool isMayor = persona.MayorEdad(edad);
            if(isMayor = true)
            {
                Console.WriteLine("Es mayor de edad");
            } 
            else
            {
                Console.WriteLine("Es menor de edad");
            }
            */

            Moneda moneda = new Moneda();
            Console.WriteLine("Ingrese Numero: ");
            moneda.numero = double.Parse(Console.ReadLine());

            double num = moneda.Centavos(moneda.numero);
            int entero = moneda.Entero();

            Console.Clear();

            Console.Write("Centavos: " + num + "\nEntero: " + entero);

            Console.ReadKey();
        }
    }
}
