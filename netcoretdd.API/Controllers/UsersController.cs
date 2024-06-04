using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using netcoretdd.API.Services;

namespace netcoretdd.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _usersService;

        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpGet(Name ="GetUsers")]
        public async Task<IActionResult> Get()
        {
            var users = await _usersService.GetAllUsers();

            if (users.Any())
            {
                return Ok(users);
            }

            return NotFound();
        }
    }
}
