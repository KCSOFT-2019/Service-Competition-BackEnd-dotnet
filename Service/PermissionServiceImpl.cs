using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RfidAPI.Data;
using RfidAPI.Models;

namespace RfidAPI.Service
{
    public class PermissionServiceImpl :PermissionService
    {
        public DataContext _Context;
        public PermissionServiceImpl(DataContext context)
        {
            _Context = context;
        }

        public bool CreateRole(Permission permission)
        {
            _Context.Permissions.Add(permission);
            return _Context.SaveChanges() > 0;
            
        }

        public bool IsRole(Permission permission)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ActionResult<IEnumerable<Permission>>> getAllPermissions()
        {
            return await _Context.Permissions.ToListAsync();
        }
    }
}