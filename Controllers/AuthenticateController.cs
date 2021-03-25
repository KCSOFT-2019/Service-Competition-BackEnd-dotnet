using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using RfidAPI.Models;

namespace RfidAPI.Controllers
{
    [Route("auth")]
    [ApiController]
    public class AuthenticateController : ControllerBase
    {
        public AuthenticateController(UserManager<IUser> userManager,
            RoleManager<IRole> roleManager,
            IConfiguration configuration)
        {
            UserManager = userManager;
            RoleManager = roleManager;
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public RoleManager<IRole> RoleManager { get; }
        public  UserManager<IUser> UserManager { get; }


        [HttpPost("register", Name = nameof(AddUserAsync))]
        public async Task<IActionResult> AddUserAsync(RegisterUser registerUser)
        {
            var user = new IUser
            {
                UserName = registerUser.UserName,
                Email = registerUser.Email
            };
            IdentityResult result = await UserManager.CreateAsync(user, registerUser.Password);
            if (result.Succeeded)
            {
                return Ok();
            }
            else
            {
                ModelState.AddModelError("Error", result.Errors.FirstOrDefault()?.Description);
                return BadRequest(ModelState);
            }
        }
    }
}