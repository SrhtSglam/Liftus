using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using project.Server.Services.UserService;

namespace project.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("all"), Authorize(Roles = "Admin")]
        public async Task<ActionResult<ServiceResponse<List<User>>>> GetUsers()
        {
            var result = await _userService.GetUsers();
            return Ok(result);
        }
    }
}
