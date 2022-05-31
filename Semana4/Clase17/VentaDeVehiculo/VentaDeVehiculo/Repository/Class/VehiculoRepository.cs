using VentaDeVehiculo.Data;
using VentaDeVehiculo.Models;
using VentaDeVehiculo.Repository.Interface;

namespace VentaDeVehiculo.Repository.Class
{
    public class VehiculoRepository : GenericRepository<Vehiculo>, IVehiculoRepository
    {
        public VehiculoRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
