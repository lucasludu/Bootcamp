using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Concesionaria.Models
{
    public class Automovil
    {
        private int idAuto;
        private string marca;
        private string modelo;
        private int anio;
        private int kilometro;
        private double precio;

        public int IdAuto { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
        public int Kilometro { get; set; }
        public double Precio { get; set; }

    }
}