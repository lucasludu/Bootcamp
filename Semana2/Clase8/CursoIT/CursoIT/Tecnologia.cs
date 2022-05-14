using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoIT
{
    class Tecnologia
    {
        private int idTecnologia;
        private string nombreTecnologia;

        public int IdTecnologia { get => idTecnologia; set => idTecnologia = value; }
        public string NombreTecnologia { get => nombreTecnologia; set => nombreTecnologia = value; }

        public Tecnologia() { }
    }
}
