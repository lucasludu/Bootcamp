using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KioscoCF.Models
{
    public class Caracteristica
    {
        public int Id { get; set; }
        [Required]
        public double Precio { get; set; }
        [Required]
        public double Ancho { get; set; }
        [Required]
        public double Largo { get; set; }
        [Required]
        public double Peso { get; set; }
        public int ProductoId { get; set; }
        [ForeignKey("ProductoId")]
        public Producto Product { get; set; }
    }
}