using VentaDeVehiculo.Data;
using VentaDeVehiculo.Models;
using VentaDeVehiculo.Repository.Interface;

namespace VentaDeVehiculo.Repository.Class
{
    public class VentaRepository : GenericRepository<Venta>, IVentaRepository
    {
        public VentaRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
