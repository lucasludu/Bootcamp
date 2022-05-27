namespace Kiosco.Repository.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int? id);
        T Insert(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
