using Microsoft.AspNetCore.Mvc;
using FP.VehiclesManager.Business.Contracts.Services;

namespace FP.VehiclesManager.Application.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleService _vehicleService;

        public VehicleController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetByIdAsync(int userId)
        {
            var vehicles = await _vehicleService.GetByIdAsync(userId);
            if (vehicles.HasErrors())
            {
                return BadRequest(vehicles.Errors);
            }
            return Ok(vehicles.Result);
        }
    }
}
