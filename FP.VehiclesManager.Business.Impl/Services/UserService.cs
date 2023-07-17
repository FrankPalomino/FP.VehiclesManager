using FP.VehiclesManager.Dtos;
using FP.VehiclesManager.Business.Contracts.Services;
using FP.VehiclesManager.Infrastructure.Contracts.Entities;
using FP.VehiclesManager.Infrastructure.Contracts.Repositories;

namespace FP.VehiclesManager.Business.Impl.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository) => _userRepository = userRepository;

        public async Task<OperationResult<IEnumerable<UserDto>>> GetAllAsync()
        {
            var operationResult = new OperationResult<IEnumerable<UserDto>>();

            var results = await _userRepository.GetAllAsync();

            operationResult.AddResult(results.Select(x => ToDto(x)).ToArray());

            return operationResult;
        }

        public async Task<OperationResult<UserDto>> GetByIdAsync(int id)
        {
            var operationResult = new OperationResult<UserDto>();

            var result = await _userRepository.GetByIdAsync(id);

            if (result == null)
            {
                operationResult.AddError($"User with id {id} not found");
                return operationResult;
            }

            operationResult.AddResult(ToDto(result));

            return operationResult;
        }

        private static UserDto ToDto(User user)
        {
            return new UserDto
            {
                Id = user.Id,
                Name = user.Name,
                Surname = user.Surname,
                Dni = user.Dni,
                Card = user.Card,
                Phone = user.Phone
            };
        }
    }
}