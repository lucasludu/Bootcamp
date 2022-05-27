using AlquilerDePeliculas.Models;
using Microsoft.EntityFrameworkCore;

namespace AlquilerDePeliculas.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Pelicula>? Peliculas { get; set; }
        public DbSet<Alquiler>? Alquileres { get; set; }
    }
}
