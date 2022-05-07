using System;
using CorteControl.Class;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteControl
{
    internal class Program
    {
        static void mostrarArchivoCSV(Persona persona)
        {
            var reader = new StreamReader(File.OpenRead(@"C:\Users\Lucaaas\Desktop\Bootcamp\Clase2\CorteControl\CorteControl\persona.csv"));
            List<Persona> listA = new List<Persona>();
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] values = line.Split(';');
                persona.legajo = int.Parse(values[0]);
                persona.nombre = values[1];
                persona.apellido = values[2];
                persona.valorHora = double.Parse(values[3]);
                persona.horasTrabajadas = int.Parse(values[4]);
                persona.sueldoCobrar = double.Parse(values[5]);
                persona.ultimoProceso = values[6];

                listA.Add(persona);
                foreach (Persona p in listA)
                {
                    Console.WriteLine("\t" + p.ToString() + "\n");
                }
            }
        }

        static void AddRecord(Persona persona)
        {
            string ruta = "C:\\Users\\Lucaaas\\Desktop\\Bootcamp\\Clase2\\CorteControl\\CorteControl\\persona.csv";//RUTA DEL ARCHIVO
            string separador = ",";//CREAMOS UN SEPARADOR
            StringBuilder salida = new StringBuilder();//CRAMOS UNA INSTANCIA STRINGBUILDER (QUE LEE EL ARRAY COMPLETO)

            string cadena = persona.ToString();
            List<string> List = new List<string>();
            List.Add(cadena);

            for (int i = 0; i < List.Count; i++)
            {
                salida.AppendLine(string.Join(separador, List[i]));// El método AppendLine agrega el terminador de línea predeterminado al final del objeto StringBuilder actual.

                File.AppendAllText(ruta, salida.ToString());//AGREGA LA CADENA AL ARCHIVO.
            }
        }
        static void Main(string[] args)
        {
            Persona persona = new Persona(42, "Daiana", "Bilhere", 100, 5, 200, "05/05/2022");

            //AddRecord(persona);
            mostrarArchivoCSV(persona);
            
            Console.ReadKey();
        }

    }
}
