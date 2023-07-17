using FP.VehiclesManager.Infrastructure.Contracts.Entities;

namespace FP.VehiclesManager.Infrastructure.Contracts.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllAsync();
        Task<User> GetByIdAsync(int id);
    }
}
