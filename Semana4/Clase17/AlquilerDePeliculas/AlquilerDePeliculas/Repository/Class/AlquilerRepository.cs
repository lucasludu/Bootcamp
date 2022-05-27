using AlquilerDePeliculas.Data;
using AlquilerDePeliculas.Models;
using AlquilerDePeliculas.Repository.Interface;

namespace AlquilerDePeliculas.Repository.Class
{
    public class AlquilerRepository : GenericRepository<Alquiler>, IAlquilerRepository
    {
        public AlquilerRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
