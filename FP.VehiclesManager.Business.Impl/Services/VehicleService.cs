using FP.VehiclesManager.Dtos;
using FP.VehiclesManager.Business.Contracts.Services;
using FP.VehiclesManager.Infrastructure.Contracts.Entities;
using FP.VehiclesManager.Infrastructure.Contracts.Repositories;

namespace FP.VehiclesManager.Business.Impl.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly IVehicleRepository _vehicleRepository;
        private readonly IUserRepository _userRepository;

        public VehicleService(IVehicleRepository vehicleRepository, IUserRepository userRepository)
        {
            _vehicleRepository = vehicleRepository;
            _userRepository = userRepository;
        }

        public async Task<OperationResult<IEnumerable<VehicleDto>>> GetByIdAsync(int userId)
        {
            var operationResult = new OperationResult<IEnumerable<VehicleDto>>();

            var user = await _userRepository.GetByIdAsync(userId);

            if (user == null)
            {
                operationResult.AddError("User not found");
                return operationResult;
            }

            var results = await _vehicleRepository.GetAllByIdAsync(userId);

            operationResult.AddResult(results.Select(x => ToDto(x)).ToArray());

            return operationResult;
        }

        private static VehicleDto ToDto(Vehicle vehicle)
        {
            return new VehicleDto
            {
                Id = vehicle.Id,
                Brand = vehicle.Brand,
                Model = vehicle.Model,
                Power = vehicle.Power
            };
        }
    }
}
