using System.ComponentModel.DataAnnotations;

namespace AlquilerDePeliculas.Models
{
    public class Pelicula
    {
        [Key]
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Genero { get; set; }
        public DateTime FechaBaja { get; set; }

    }
}
