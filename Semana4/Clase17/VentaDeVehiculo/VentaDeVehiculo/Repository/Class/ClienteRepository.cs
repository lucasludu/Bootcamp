using VentaDeVehiculo.Data;
using VentaDeVehiculo.Models;
using VentaDeVehiculo.Repository.Interface;

namespace VentaDeVehiculo.Repository.Class
{
    public class ClienteRepository : GenericRepository<Cliente>, IClienteRepository
    {

        public ClienteRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
