using FP.VehiclesManager.Infrastructure.Contracts.Entities;
using FP.VehiclesManager.Infrastructure.Contracts.Repositories;
using FP.VehiclesManager.Infrastructure.Impl.Contexts;
using Microsoft.EntityFrameworkCore;

namespace FP.VehiclesManager.Infrastructure.Impl.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly VehiclesManagerDbContext _context;
        public UserRepository(VehiclesManagerDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
