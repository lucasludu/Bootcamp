using Kiosco.Data;
using Kiosco.Repository.Class;
using Microsoft.EntityFrameworkCore;

namespace Kiosco.Repository.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IProductoRepository ProductoRepository { get; }
        ICaracteristicaRepository CaracteristicaRepository { get; }
        void SaveChanges();
    }
}