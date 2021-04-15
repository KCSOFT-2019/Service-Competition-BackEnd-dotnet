/*using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RfidAPI.Data;
using RfidAPI.Models;

namespace RfidAPI.Service
{
    
    public class UserServiceImpl : UserService
    {
        public DataContext _context;

        public UserServiceImpl(DataContext context)
        {
            _context = context;
        }
        public bool CreateUser(User user)
        {
            _context.IUsers.Add(user);
            return _context.SaveChanges() > 0;
            throw new System.NotImplementedException();
        }

        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
            throw new System.NotImplementedException();
        }

        public User GetUserByFaceInfo(string faceinfo)
        {
            var user = _context.Users.SingleOrDefault(s => s.faceInfo == faceinfo);
            return user;
        }

        public int GetRole(int id)
        {
            return _context.Users.SingleOrDefault(S => S.UserId == id).permissionId;
        }
    }
}*/