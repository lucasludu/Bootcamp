using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoCRUD.Models
{
    public class Contacto
    {
        public int idContacto { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
    }
}