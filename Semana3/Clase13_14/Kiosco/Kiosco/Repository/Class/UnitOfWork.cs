using Microsoft.EntityFrameworkCore;
using Kiosco.Repository.Interfaces;
using System.Data.Entity;
using Kiosco.Data;
using Kiosco.Models;

namespace Kiosco.Repository.Class
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _context = dbContext;
            ProductoRepository = new ProductoRepository(_context);
            CaracteristicaRepository = new CaracteristicaRepository(_context);
        }
        public IProductoRepository ProductoRepository { get; private set; }
        public ICaracteristicaRepository CaracteristicaRepository { get; private set; }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            _context.Dispose();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }
}
