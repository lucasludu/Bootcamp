using System;
using ReviewChallenge.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewChallenge.Class
{
    public abstract class Persona : Archivo
    {
        protected string nombre;
        protected string apellido;
        protected int edad;
        protected Documento documento;

        protected Persona(string nombre, string apellido, int edad, Documento documento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.documento = documento;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public Documento Documento { get => documento; set => documento = value; }

        public void Expulsado()
        {
            Console.WriteLine("El alumno fue expulsado por mal comportamiento");
        }

        public void Parcial()
        {
            Console.WriteLine("DESAPROBADO!!!");
        }

        public override string ToString()
        {
            return "Nombre y Apellido: " + nombre + ", " + apellido + ", Edad: " + edad + ", Documento: " + Documento.ToString();
        }
    }
}
