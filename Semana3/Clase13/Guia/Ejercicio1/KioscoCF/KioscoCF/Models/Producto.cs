using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KioscoCF.Models
{
    public class Producto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(100)]
        public string Categoria { get; set; }
        [Required]
        public DateTime FechaBaja { get; set; }

        public List<Caracteristica> Caracteristicas { get; set; }

    }
}