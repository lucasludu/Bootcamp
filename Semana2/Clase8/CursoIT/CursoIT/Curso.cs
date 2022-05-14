using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoIT
{
    class Curso
    {
        private int idCurso;
        private int idTecnologia;
        private string nombre;
        private string fechaInicio;
        private string fechaFinal;
        private int cantidadAlumnos;

        public int IdCurso { get => idCurso; set => idCurso = value; }
        public int IdTecnologia { get => idTecnologia; set => idTecnologia = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public string FechaFinal { get => fechaFinal; set => fechaFinal = value; }
        public int CantidadAlumnos { get => cantidadAlumnos; set => cantidadAlumnos = value; }

        public Curso() { }
    }
}
