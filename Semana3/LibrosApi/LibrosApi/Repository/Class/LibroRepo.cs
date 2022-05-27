using LibrosApi.Data;
using LibrosApi.Models;
using LibrosApi.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LibrosApi.Repository.Class
{
    public class LibroRepo : GenericRepo<Libro>, ILibroRepo
    {
        ApplicationDbContext _db;
        public LibroRepo(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<Libro> GetLibrosYAutores()
        {
            var aux = _db.Libros.Include(x => x.Autor).ToList();
            return aux;
        }
    }
}
