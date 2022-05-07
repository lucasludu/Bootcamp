using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio1.Class;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();

            persona.Saludar();

            Estudiante estudiante = new Estudiante(15);

            estudiante.Saludar();
            Console.WriteLine(estudiante.Edad);
            estudiante.Estudiar();

            Profesor profesor = new Profesor(54);
            profesor.Explicar();

            Console.ReadKey();

        }
    }
}
