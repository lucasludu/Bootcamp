using AlquilerDePeliculas.Repository.Interface;

namespace AlquilerDePeliculas.UOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IPeliculaRepository PeliculasR { get; }
        IAlquilerRepository AlquileresR { get; }
        void Save();
    }
}
