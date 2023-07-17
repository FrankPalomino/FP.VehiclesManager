using FP.VehiclesManager.Infrastructure.Contracts.Entities;
using FP.VehiclesManager.Infrastructure.Contracts.Repositories;
using FP.VehiclesManager.Infrastructure.Impl.Contexts;
using Microsoft.EntityFrameworkCore;

namespace FP.VehiclesManager.Infrastructure.Impl.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly VehiclesManagerDbContext _context;
        public VehicleRepository(VehiclesManagerDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Vehicle>> GetAllByIdAsync(int userId)
        {
            return await _context.Vehicles.Where(x => x.UserId == userId).ToListAsync();
        }
    }
}
