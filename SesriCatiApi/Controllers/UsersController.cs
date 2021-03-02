using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using SesriCatiApi.Services;
using System.Threading.Tasks;
using SesriCatiApi.Models;
using System.DirectoryServices.AccountManagement;

namespace SesriCatiApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] AuthenticateModel model)
        {
            var user = await _userService.Authenticate(model.Username, model.Password);

            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(user);
        }

        // Get function to check with Directoryservices
        [AllowAnonymous]
        [HttpGet("authAD")]
        public bool AuthenticateAD([FromBody] AuthenticateModel model)
        {
            var valid = _userService.ValidateCredentials(model.Username, model.Password);

            return valid;

        }

        [AllowAnonymous]
        [HttpGet("authWithAD")]
        public Principal AuthenticateWithAD([FromBody] AuthenticateModel model)
        {
            var user = _userService.AuthWithAD(model.Username, model.Password);

            return user;

        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var users = await _userService.GetAll();
            return Ok(users);
        }
    }
}
