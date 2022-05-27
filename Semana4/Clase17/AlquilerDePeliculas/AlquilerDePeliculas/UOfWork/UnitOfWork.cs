using AlquilerDePeliculas.Data;
using AlquilerDePeliculas.Repository.Class;
using AlquilerDePeliculas.Repository.Interface;

namespace AlquilerDePeliculas.UOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IPeliculaRepository PeliculasR { get; private set; }

        public IAlquilerRepository AlquileresR { get; private set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            PeliculasR = new PeliculaRepository(context);
            AlquileresR = new AlquilerRepository(context);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
