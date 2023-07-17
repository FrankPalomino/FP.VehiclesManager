using FP.VehiclesManager.Infrastructure.Contracts.Entities;

namespace FP.VehiclesManager.Infrastructure.Contracts.Repositories
{
    public interface IVehicleRepository
    {
        Task<IEnumerable<Vehicle>> GetAllByIdAsync(int userId);
    }
}
