using KioscoCF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KioscoCF.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("DefaultConnection") { }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Caracteristica> Caracteristicas { get; set; }
    }
}