using System;
using ReviewChallenge.Interface;
using ReviewChallenge.Class;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewChallenge
{
    internal class Program
    {
        /* 
         * implementar dos clases que llamemos en este caso,  Suma y Resta. Cada clase tiene como atributo valor1, valor2  
         * y resultado. En este caso , las propiedades a definir son Valor1, Valor2 y Resultado, el método Operar (que en 
         * el caso de la clase "Suma" suma los dos Valores y en el caso de la clase "Resta" hace la diferencia entre Valor1 
         * y Valor2.
         */

        static void Main(string[] args)
        {
            int opcion;
            do
            {
                try
                {
                    do
                    {
                        try
                        {
                            Console.WriteLine("--------------------- menu ------------------");
                            Console.WriteLine("Ejercicio de operaciones de suma y resta");
                            Console.WriteLine("Ejercicio propuesta en clase [ Alumnos ]");
                            Console.WriteLine("para retirarse opcion 0");

                            opcion = int.Parse(Console.ReadLine());
                        }
                        catch (Exception error)
                        {
                            Console.WriteLine(error.Message);
                            opcion = 3;
                        }
                        Console.ReadKey();
                        Console.Clear();
                    } while (opcion < 0 || opcion > 2);

                    switch(opcion)
                    {
                        case 1:
                            do
                            {
                                do
                                {
                                    try
                                    {
                                        Console.WriteLine("---------------------sub-menu ------------------");
                                        Console.WriteLine("para sumar opcion 1");
                                        Console.WriteLine("para restar opcion 2");
                                        Console.WriteLine("para retirarse opcion 0");

                                        opcion = int.Parse(Console.ReadLine());
                                    }
                                    catch (Exception error)
                                    {
                                        Console.WriteLine(error.Message);
                                        opcion = 3;
                                    }
                                    Console.ReadKey();
                                    Console.Clear();
                                } while (opcion < 0 || opcion > 2);

                                switch (opcion)
                                {
                                    case 1:
                                        bool flag = true;
                                        do
                                        {
                                            try
                                            {
                                                Console.WriteLine("ingrese el primer valor");
                                                int num1 = int.Parse(Console.ReadLine());

                                                Console.WriteLine("ingrese el segundo valor");
                                                int num2 = int.Parse(Console.ReadLine());

                                                Suma suma = new Suma(num1, num2);
                                                Console.WriteLine("El resultado es: " + suma.ToString());

                                                flag = true;
                                            }
                                            catch (Exception error)
                                            {
                                                Console.WriteLine(error.Message);
                                                flag = false;
                                            }
                                        } while (flag == false);

                                        Console.ReadKey();
                                        break;

                                    case 2:
                                        do
                                        {
                                            try
                                            {
                                                Console.WriteLine("ingrese el primer valor");
                                                int num1 = int.Parse(Console.ReadLine());

                                                Console.WriteLine("ingrese el segundo valor");
                                                int num2 = int.Parse(Console.ReadLine());

                                                Resta resta = new Resta(num1, num2);
                                                Console.WriteLine("El resultado es: " + resta.ToString());

                                                flag = true;
                                            }
                                            catch (Exception error)
                                            {
                                                Console.WriteLine(error.Message);
                                                flag = false;
                                            }
                                        } while (flag == false);

                                        Console.ReadKey();
                                        break;
                                }
                                Console.ReadKey();
                                Console.Clear();
                            } while (opcion != 0);
                            break;

                        case 2:
                            Alumno alumno = new Alumno("Nahuel", "Riizzooo", 32, new Documento("DNI", 20454789), "Matematica");
                            Console.WriteLine("Alumno: " + alumno.Nombre + ", " + alumno.Apellido + " " + alumno.Documento.ToString() + "\nEsta cursando" + alumno.Materia);
                            alumno.Parcial();
                            Console.ReadKey();
                            break;
                    }
                    
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                    opcion = 3;
                }
                Console.ReadKey();
                Console.Clear();
            } while (opcion != 0);
        }
            
    }
}
