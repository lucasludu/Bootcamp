using LibrosApi.Data;
using LibrosApi.Models;
using LibrosApi.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LibrosApi.Repository.Class
{
    public class AutorRepo : GenericRepo<Autor>, IAutorRepo
    {
        ApplicationDbContext _db;
        public AutorRepo(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<Autor> GetAutoresYLibros()
        {
            var entity = _db.Autors.Include(x => x.Libros).ToList();
            return entity;
        }

    }

}
