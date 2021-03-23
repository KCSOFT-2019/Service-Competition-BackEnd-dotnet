using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RfidAPI.Models;
using RfidAPI.Service;

namespace RfidAPI.Controllers
{
    public class PerimissionController : ControllerBase
    {
        private readonly PermissionService _permissionService;

        public PerimissionController(PermissionService permissionService)
        {
            _permissionService = permissionService;
        }
        
        
        [HttpPost]
        [Route("api/permission/add")]
        public ActionResult<string> Create(Permission permission)
        {
            var result  = _permissionService.CreateRole(permission);
            if (result)
            {
                return "permission create successfully";
            }
            else
            {
                return "permission create unsuccessfully";
            }
        }


        [HttpGet]
        [Route("api/permission/getAll")]
        public Task<ActionResult<IEnumerable<Permission>>> Gets()
        {
            return _permissionService.getAllPermissions();
        }
    }
}