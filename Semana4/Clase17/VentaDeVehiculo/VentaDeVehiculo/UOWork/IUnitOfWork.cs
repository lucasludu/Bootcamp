using VentaDeVehiculo.Repository.Interface;

namespace VentaDeVehiculo.UOWork
{
    public interface IUnitOfWork : IDisposable
    {
        IClienteRepository ClienteRepo { get; }
        IVentaRepository VentaRepo { get; }
        IVehiculoRepository VehiculoRepo { get; }
        void Save();
    }
}
