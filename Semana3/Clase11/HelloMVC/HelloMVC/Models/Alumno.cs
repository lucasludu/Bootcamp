using System;

namespace HelloMVC.Models
{
    public class Alumno
    {
        public int IdAlumno { get; set; }
        public string Nombre { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public DateTime FechaAlta { get; set; }
        public int Edad { get; set; }
    }
}
