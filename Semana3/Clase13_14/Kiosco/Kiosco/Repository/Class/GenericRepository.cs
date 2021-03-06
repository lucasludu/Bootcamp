using Kiosco.Data;
using Kiosco.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Kiosco.Repository.Class
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;

        public GenericRepository(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int? id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Delete(int id)
        {
            //_entity.Remove(entity);
            var entity = GetById(id);
            if(entity == null)
            {
                throw new Exception("No se encontro el objeto");
            }
            _context.Set<T>().Remove(entity);
        }

        public T Insert(T entity)
        {
            _context.Set<T>().Add(entity);
            return entity;
        }

        public void Update(T entity)
        {
            _context.Update(entity);
        }

    }
}
