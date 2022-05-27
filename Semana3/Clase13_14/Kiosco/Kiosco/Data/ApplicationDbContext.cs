using Kiosco.Models;
using Microsoft.EntityFrameworkCore;

namespace Kiosco.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Caracteristica> Caracteristicas { get; set; }
    }
}
