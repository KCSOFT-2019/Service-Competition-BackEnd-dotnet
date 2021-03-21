using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RfidAPI.Models;

namespace RfidAPI.Service
{
    public interface PermissionService
    {
        bool CreateRole(Permission permission);

        bool IsRole(Permission permission);

        Task<ActionResult<IEnumerable<Permission>>> getAllPermissions();
    }
}