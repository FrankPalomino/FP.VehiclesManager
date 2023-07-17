using FP.VehiclesManager.Dtos;

namespace FP.VehiclesManager.Business.Contracts.Services
{
    public interface IUserService
    {
        Task<OperationResult<IEnumerable<UserDto>>> GetAllAsync();
        Task<OperationResult<UserDto>> GetByIdAsync(int id);
    }
}