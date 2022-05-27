using LibrosApi.Models;
using Microsoft.EntityFrameworkCore;

namespace LibrosApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Autor> Autors { get; set; }
        public DbSet<Libro> Libros { get; set; }
    }
}
