using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewChallenge.Class
{
    public class Alumno : Persona
    {
        private string materia;

        public Alumno(string nombre, string apellido, int edad, Documento documento, string materia) : base(nombre, apellido, edad, documento)
        {
            this.materia = materia;
        }
        public string Materia { get => materia; set => materia = value; }

        public override String ToString()
        {
            return "El alumno esta cursando: " + materia;
        }
    }
}
