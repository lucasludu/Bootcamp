using AlquilerDePeliculas.Data;
using AlquilerDePeliculas.Models;
using AlquilerDePeliculas.Repository.Interface;

namespace AlquilerDePeliculas.Repository.Class
{
    public class PeliculaRepository : GenericRepository<Pelicula>, IPeliculaRepository
    {
        public PeliculaRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
