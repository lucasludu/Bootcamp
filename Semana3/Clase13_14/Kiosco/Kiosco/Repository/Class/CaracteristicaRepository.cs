using Kiosco.Data;
using Kiosco.Models;
using Kiosco.Repository.Interfaces;

namespace Kiosco.Repository.Class
{
    public class CaracteristicaRepository : GenericRepository<Caracteristica>, ICaracteristicaRepository
    {
        public CaracteristicaRepository(ApplicationDbContext dbContext) : base(dbContext) 
        {

        }
    }
}
