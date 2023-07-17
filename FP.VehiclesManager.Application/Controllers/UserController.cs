using Microsoft.AspNetCore.Mvc;
using FP.VehiclesManager.Business.Contracts.Services;

namespace FP.VehiclesManager.Application.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var users = await _userService.GetAllAsync();
            if (users.HasErrors())
            {
                return BadRequest(users.Errors);
            }
            return Ok(users.Result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var user = await _userService.GetByIdAsync(id);
            if (user.HasErrors())
            {
                return BadRequest(user.Errors);
            }
            return Ok(user.Result);
        }
    }
}
