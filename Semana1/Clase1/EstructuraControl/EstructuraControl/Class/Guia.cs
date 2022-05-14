using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraControl
{
    public class Guia
    {


        /*
        * Ejercicio 1:  Realiza un programa que sume los 100 números siguientes a un número entero 
        * y positivo introducido por teclado. Se debe comprobar que el dato introducido es correcto
        */

        public void ejercicio1()
        {
            int numero = 0;

            do
            {
                Console.WriteLine("Introduzca un numero: ");
                numero = int.Parse(Console.ReadLine());

                if (numero < 0)
                {
                    Console.WriteLine("El numero tiene que ser Positivo.");
                }
            } while (numero < 0);

            int suma = 0;

            for (int i = numero; i < numero + 100; i++)
            {
                suma += i;
            }

            Console.WriteLine("La suma de los siguientes 100 numeros es de: " + suma);

            Console.ReadKey();
        }

        /*
            * Ejercicio 2:  Escribe un programa que obtenga los números enteros comprendidos entre dos 
            * números introducidos por teclado y validados como distintos, el programa debe empezar por 
            * el menor de los enteros introducidos e ir incrementando de 7
            */

        public void ejercicio2()
        {
            int numero1;
            int numero2;

            do
            {
                Console.WriteLine("Ingresar Primer Numero");
                numero1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresar Segundo Numero");
                numero2 = int.Parse(Console.ReadLine());
            } while (numero1 == numero2);

            if (numero1 == numero2)
            {
                Console.WriteLine("Los numeros deben ser distintos");
            }

            if (numero1 > numero2)
            {
                int aux = numero1;
                numero1 = numero2;
                numero2 = aux;
            }

            for (int i = numero1; i <= numero2; i += 7)
            {
                Console.WriteLine(i + " ");
            }

            Console.ReadKey();
        }

        /*
            * Ejercicio 3: Escribe un programa que permita ir introduciendo una serie indeterminada de 
            * números mientras su suma no supere el valor de 150 Cuando esto último ocurra, se debe 
            * mostrar el total acumulado, el contador de los números introducidos y la media.
            */

        public void ejercicio3()
        {
            int numero = 0;
            int cantidadNumeros = 0;
            int suma = 0;

            do
            {
                Console.WriteLine("Introduzca un numero: ");
                numero = int.Parse(Console.ReadLine());
                suma += numero;
                cantidadNumeros++;
            } while (numero <= 150);

            Console.WriteLine("Se introdujo una cantidad de " + cantidadNumeros + " numeros y su suma fue de: " + suma);

            Console.ReadKey();
        }

        /* 
            * Ejercicio 4: Calcular el salario de un trabajador, ingresando las horas trabajadas y el 
            * valor por hora, se debe mostrar el nombre del trabajador.
            */

        public void ejercicio4()
        {
            double salario = 0;
            int JORNADA = 48;
            int horasTrabajadas;
            double valorHora;
            string nombreTrabajador;

            // Se ingresa el nombre del trabajador
            Console.WriteLine("Ingrese el nombre del trabajador: ");
            nombreTrabajador = Console.ReadLine();

            // Ingreso las horas trabajadas
            Console.WriteLine("Ingrese las horas trabajadas: ");
            horasTrabajadas = int.Parse(Console.ReadLine());

            // Ingreso el valor de las horas trabajadas
            Console.WriteLine("Ingrese el valor de las horas trabajadas: ");
            valorHora = double.Parse(Console.ReadLine());

            // Calculo el salario
            salario = (double)horasTrabajadas * valorHora;

            // Respuesta del problema
            Console.WriteLine("Horas totales: " + horasTrabajadas + ", valor por hora: " + valorHora + "y su salario es de: " + salario);

            // Verificico si tiene o no horas extras
            int horasExtras = horasTrabajadas - JORNADA;
            if (horasTrabajadas > JORNADA)
            {
                Console.WriteLine("Tiene " + horasExtras + " horas extras.");
            }
            else
            {
                Console.WriteLine("No tiene horas extras.");
            }

            Console.ReadKey();
        }

        /*
            * Ejercicio 5: En una carretera se ha colocado un radar que detecta la velocidad del vehículo 
            * que pasa y el tipo de vehículo: 0 Bicicleta, 1 Moto, 2 Coche, 3 Camión, 4 Error.El proceso 
            * se interrumpe si se generan 1000 señales o si se producen 2 errores consecutivos. 
            * Al final se debe mostrar una estadística que indique el número total de vehículos que han 
            * pasado, el número de errores y los porcentajes de cada caso. También se debe indicar el máximo 
            * intervalo (medido en número de vehículos) entre dos coches.
            */

        /* 
            * Ejercicio 6: Calcular el monto a pagar en una cabina de Internet si el costo por hora es de $1,5 
            * y por cada 5 horas te dan una hora de promoción gratis, sabiendo que la permanencia en la cabina  
            * fue de 12 horas.
            */

        public void ejercicio6()
        {
            double montoPagar = 0;
            double COSTO_HORA = 1.5;
            double promocion;
            double horasConsumidas;

            Console.WriteLine("Ingrese el numero de horas consumidas: ");
            horasConsumidas = double.Parse(Console.ReadLine());

            promocion = (double)horasConsumidas / 5;
            if (promocion >= 1)
            {
                Console.WriteLine("Tiene una promocion de " + Math.Round(promocion) + " hora.");
            }
            else
            {
                Console.WriteLine("No tiene promocion.");
                promocion = 0;
            }

            montoPagar = (horasConsumidas - promocion) * COSTO_HORA;
            Console.WriteLine("Usted Consumio " + horasConsumidas + ", el monto es de $" + montoPagar);

            Console.ReadKey();
        }


        /* 
            * Ejercicio 7: Ingresar un tiempo en segundos y separarlos en horas, minutos y segundos 
            */

        public void ejercicio7(int segundos)
        {
            int minutosHoras = segundos / 60;
            int Rsegundos = segundos % 60;
            int Rhora = minutosHoras / 60;
            int Rminutos = minutosHoras / 60;

            Console.WriteLine("\n{0} Los segundos equivalen a: " +
                                "\n{1} Horas: " +
                                "\n{2} Minutos: " +
                                "\n{3} Segundos: ", segundos, Rhora, Rminutos, Rsegundos);

            Console.ReadKey();
        }

        /* 
            * Ejercicio 8: Calcular el nuevo salario de un empleado si obtuvo un incremento del 8% sobre su salario 
            * actual y un descuento de 2,5% por servicios.
            */

        public void ejercicio8()
        {
            double salario;
            double nuevoSalario = 0;

            Console.WriteLine("Ingrese el salario del trabajador: ");
            salario = double.Parse(Console.ReadLine());

            double incremento = salario * 8 / 100;
            Console.WriteLine("Incremento de: " + incremento);

            double descuento = salario * 2.5 / 100;
            Console.WriteLine("Descuento de: " + descuento);

            nuevoSalario = salario + incremento - descuento;
            Console.WriteLine("El nuevo salario es de: " + nuevoSalario);

            Console.ReadKey();
        }

        /* 
            * Ejercicio 9: Calcular el área de un trapecio
            */

        public double ejercicio9(double baseMenor, double baseMayor, double altura)
        {
            double area = 0;

            area = (baseMenor + baseMayor) * altura / 2;
            return area;

            Console.ReadKey();
        }


        /* 
            * Ejercicio 10: Un empresario decide heredar su terreno a sus 3 hijos, tomando como referencia la cantidad de 
            * hijos, al mayor que tiene 6 hijos le otorga el doble del menor, al que tiene 2 hijos le corresponde 
            * 125.2 mt2, al menor le otorga el 27% del total del terreno. Calcular el total del terreno y la 
            * cantidad que le corresponde a cada hijo.
            */


        /* 
            * Ejercicio 11:  Escribe un programa que lea un número N e imprima una pirámide de números con N filas
            */

        public void ejercicio11()
        {
            int alturaIntroducida;
            Console.WriteLine("Introduzca la altura de la piramide");
            alturaIntroducida = Int32.Parse(Console.ReadLine());

            int altura = 1;
            int i = 0;
            int espacios = alturaIntroducida - 1;

            while (altura <= alturaIntroducida)
            {
                // Insertar espacios
                for (i = 1; i <= espacios; i++)
                {
                    Console.Write(" ");
                }
                // Hace las lineas
                for (i = 1; i < altura; i++)
                {
                    Console.Write(i);
                }
                // Invierte la lineas
                for (i = altura; i > 0; i--)
                {
                    Console.Write(i);
                }
                Console.WriteLine("");
                altura++;
                espacios--;
            }
            Console.ReadKey();
        }


        /* 
            * Ejercicio 12: En un almacen existen multitud de artículos, sabemos que: Todos tienen un código de 7 
            * dígitos El primer dígito indica el departamento al que pertenece. 
            * Hay 9 departamentos, por tanto se usan números del 1 al 9. 
            * El 2º y 3ª dígito indica el tipo de artículo (va del 01 al 20). 
            * Con los dígitos 4,5,6 y 7, se calcula el precio teniendo presente que éste se obtiene multiplicando el 
            * valor que representan los 4 dígitos por el número del departamento al que pertenece el artículo, dividiendo por 
            * 100 y tomando el valor entero de ese resultado que a su vez se multiplica por una constante llamada constante de 
            * beneficio que actualmente es de 3.5.
            * El resultado final será el precio unitario del artículo.
            * Realiza un programa que pregunte Desea consulta? (Sí/No), en caso afirmativo se introduce el código y en pantalla 
            * debe salir: Departamento: Artículo: Precio: 
            * Se debe controlar la entrada de códigos erróneos.
            */

        /* 
            * 13.- Calcular el nuevo salario de un obrero, si obtuvo un incremento semestral del 25% sobre su salario anterior, 
            * y mostrar el total cobrado de los meses con el nuevo salario, si solo trabajó 10 meses.
            */

        public void ejercicio13()
        {
            double salarioAnterior;
            double nuevoSalario;
            string nombreObrero;

            Console.WriteLine("Ingrese el nombre del obrero: ");
            nombreObrero = Console.ReadLine();

            Console.WriteLine("Ingrese el salario anterior: ");
            salarioAnterior = double.Parse(Console.ReadLine());

            nuevoSalario = 1.25 * salarioAnterior;

            Console.WriteLine("El nuevo salario a recibir es de: {0:C2}", nuevoSalario);
            Console.WriteLine("El salario de los proximos 10 meses sera de: {0:C2}", nuevoSalario * 10);

            Console.ReadKey();
        }

        /* 
            * 14 -  Queremos conocer los datos estadísticos de una materia, por lo tanto, necesitamos un algoritmo que lea el número 
            * de reprobados, aprobados, notables y sobresalientes, y nos devuelva: 
            *  A.El tanto por ciento de alumnos que han superado la asignatura.
            *  B.El tanto por ciento de reprobados, aprobados, notables y sobresalientes de la asignatura
            */

        public void ejercicio14()
        {
            int numero_de_aprobados, numero_de_desaprobados, numero_de_notables, numero_de_sobresalientes;
            double porcentaje_superados, porcentaje_desaprobados, porcentaje_aprobados, porcentaje_notables, porcentaje_sobresalientes;
            int total;
            Console.WriteLine("Ingresa el valor de numero de aprobados:");
            numero_de_aprobados = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el valor de numero de desaprobados:");
            numero_de_desaprobados = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el valor de numero de notables:");
            numero_de_notables = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el valor de numero de sobresalientes:");
            numero_de_sobresalientes = Int32.Parse(Console.ReadLine());

            total = numero_de_desaprobados + numero_de_aprobados + numero_de_notables + numero_de_sobresalientes;

            porcentaje_superados = 100 * (numero_de_aprobados + numero_de_notables + numero_de_sobresalientes) / total;
            porcentaje_desaprobados = 100 * numero_de_desaprobados / total;
            porcentaje_aprobados = 100 * numero_de_aprobados / total;
            porcentaje_notables = 100 * numero_de_notables / total;
            porcentaje_sobresalientes = 100 * numero_de_sobresalientes / total;

            Console.WriteLine("Valor de porcentaje aprobados: " + porcentaje_aprobados);
            Console.WriteLine("Valor de porcentaje desaprobados: " + porcentaje_desaprobados);
            Console.WriteLine("Valor de porcentaje notables: " + porcentaje_notables);
            Console.WriteLine("Valor de porcentaje sobresalientes: " + porcentaje_sobresalientes);
            Console.WriteLine("Valor de total: " + total);
            Console.ReadKey();
        }


        /* 
            * 15 - El coste de un automóvil nuevo para un comprador es la suma total del coste del vehículo, del porcentaje de la 
            * ganancia del vendedor y de los impuestos locales o estatales aplicables (sobre el precio de venta). Suponer una ganancia 
            * del vendedor del 12% en todas las unidades y un impuesto del 6% y diseñar un algoritmo para leer el coste total del 
            * automóvil e imprimir el coste para el consumidor.
            */


        /* 
            * 16 -  Queremos realizar un pequeño programa para introducirlo en el ordenador de a bordo de nuestro coche y que nos 
            * informe del consumo medio del coche.Diseña un algoritmo que lea el kilometraje de la última vez que se cargó combutible, 
            * el kilometraje actual, los litros de gasolina que se repostaron la última vez y la cantidad de gasolina actual. 
            * El algoritmo devolverá la cantidad de litros cada 100 kilómetros que consume nuestro coche.
            */

        public void ejercicio16()
        {
            int valida = 0;//usamos este valida para el bloque try/catch
            do//ciclo que repite el proceso de validación del bloque try/catch
            {
                try
                {
                    double totalkm = 0, preciogaso = 0, totalviaje = 0, horas = 0, minutos = 0;
                    double litros = 0, litrosxkm = 0, dineroxkm = 0, horasT = 0, kmh = 0, ms = 0, litrosc100 = 0, dolaresc100 = 0;
                    string tiempo = "";
                    string[] tiempoD;

                    do
                    {
                        Console.WriteLine("Ingrese el total de km recorridos");
                        totalkm = Math.Round(double.Parse(Console.ReadLine()), 2);
                        if (totalkm <= 0)
                        {
                            Console.WriteLine("El ingreso debe ser mayor a cero");
                        }
                    } while (totalkm <= 0);//este bloque valida que el ingreso de kilómetros no sea menor a cero
                    do
                    {
                        Console.WriteLine("Ingrese el precio de la gasolina por litro");
                        preciogaso = Math.Round(double.Parse(Console.ReadLine()), 2);//así mismo para pedir precio de gasolina
                        if (preciogaso <= 0)
                        {
                            Console.WriteLine("El ingreso debe ser mayor a cero");
                        }
                    } while (preciogaso <= 0);
                    do
                    {
                        Console.WriteLine("Ingrese el total de dinero gastado en el viaje");
                        totalviaje = Math.Round(double.Parse(Console.ReadLine()), 2);//dato de dinero gastado para los cálculos correspondientes
                        if (totalviaje <= 0)
                        {
                            Console.WriteLine("El ingreso debe ser mayor a cero");
                        }
                    } while (totalviaje <= 0);
                    do
                    {
                        Console.WriteLine("Ingrese el tiempo que se ha tardado");
                        tiempo = Console.ReadLine();//dato del tiempo utilizado
                        tiempoD = tiempo.Split(':');//este maneja el tipo de ingreso de tiempos como separador
                        if (tiempoD.Length != 2)
                        {
                            Console.WriteLine("formato incorrecto por favor seguir HH:MM");//se valida el ingreso de acuerdo al formato que hemos dado
                        }
                        else
                        {
                            try
                            {
                                horas = Math.Round(double.Parse(tiempoD[0].ToString()), 2);//este bloque realiza el recorrido
                                //del ingreso del tiempo usando la variable horas
                                minutos = Math.Round(double.Parse(tiempoD[1].ToString()), 2);
                                if ((minutos > 59) || (minutos <= 0))//se valida el ingreso correcto
                                {
                                    Console.WriteLine("Minutos no válidos");
                                }
                                litros = totalviaje / preciogaso;//procesos necesarios para resultados correctos
                                litrosxkm = Math.Round((litros / totalkm), 2);
                                dineroxkm = Math.Round((totalviaje / totalkm), 2);
                                horasT = Math.Round((horas + minutos / 60), 2);
                                kmh = Math.Round((totalkm / horasT), 2);
                                ms = Math.Round(((kmh * 1000) / (horasT * 3600)), 2);
                                litrosc100 = Math.Round((litrosxkm * 100), 2);
                                dolaresc100 = Math.Round((dineroxkm * 100), 2);


                            }
                            catch (Exception)
                            {
                                minutos = 60;
                                Console.WriteLine("Ingrese horas y minutos en numeros");
                            }
                        }
                    } while ((minutos > 59) || (tiempoD.Length != 2) || (minutos <= 0));
                    //Ahora lo que hacemos en concatenar nuestros resultados con la información necesaria a mostrar
                    Console.WriteLine("Consumo de gasolina por cada 100km : {litros: " + litrosc100 + ", dólares: " + dolaresc100 + " }");
                    Console.WriteLine("Consumo de gasolina por cada km : {litros: " + litrosxkm + ", dólares: " + dineroxkm + " }");
                    Console.WriteLine("Velocidad media: {km/h: " + kmh + ", m/s: " + ms + "}\n");
                }
                catch (Exception)
                {
                    valida = 1;
                    Console.WriteLine("Entrada no válida");
                }
            } while (valida == 1);
            Console.ReadLine();
        }

    }

}
