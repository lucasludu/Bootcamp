using Kiosco.Data;
using Kiosco.Models;
using Kiosco.Repository.Interfaces;

namespace Kiosco.Repository.Class
{
    public class ProductoRepository : GenericRepository<Producto>, IProductoRepository
    {
        public ProductoRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
