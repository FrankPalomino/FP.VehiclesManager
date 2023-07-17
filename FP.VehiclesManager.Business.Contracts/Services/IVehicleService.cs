using FP.VehiclesManager.Dtos;

namespace FP.VehiclesManager.Business.Contracts.Services
{
    public interface IVehicleService
    {
        Task<OperationResult<IEnumerable<VehicleDto>>> GetByIdAsync(int userId);
    }
}
