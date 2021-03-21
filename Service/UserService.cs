using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RfidAPI.Models;

namespace RfidAPI.Service
{
    public interface UserService
    {
        bool CreateUser(User user);

        Task<ActionResult<IEnumerable<User>>> GetUsers();
        
        
    }
}