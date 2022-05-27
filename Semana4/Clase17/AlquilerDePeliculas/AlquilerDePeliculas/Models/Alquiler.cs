using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlquilerDePeliculas.Models
{
    
    public class Alquiler
    {
        [Key]
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public double Precio { get; set; }

        public int PeliculaId { get; set; }
        public List<Pelicula>? Pelicula { get; set; }

    }
}
