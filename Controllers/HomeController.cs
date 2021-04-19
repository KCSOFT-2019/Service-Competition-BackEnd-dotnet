using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RfidAPI.Models;

namespace RfidAPI.Controllers
{
    public class HomeController : ControllerBase
    {

        private readonly UserManager<IUser> _userManager;

        public HomeController(UserManager<IUser> userManager)
        {
            _userManager = userManager;
        }
        
        [Authorize]
        [HttpGet("user/name")]
        public async Task<string> GetName()
        {
           var name =  HttpContext.User.Claims.FirstOrDefault(c => c.Type == "jti").Value;
           //var name = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
           
            return name;
        }
        
    }
}