using Microsoft.EntityFrameworkCore;
using VentaDeVehiculo.Models;

namespace VentaDeVehiculo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Venta>? Ventas { get; set; }
        public DbSet<Cliente>? Clientes { get; set; }
        public DbSet<Vehiculo>? Vehiculos { get; set; }
    }
}
