using LibrosApi.Repository.Class;

namespace LibrosApi.Repository.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        LibroRepo libroRepository { get; }
        AutorRepo autorRepository { get; }
        void SaveChanges();
    }
}
