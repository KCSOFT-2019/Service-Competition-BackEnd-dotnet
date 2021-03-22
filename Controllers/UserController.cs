﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RfidAPI.Models;
using RfidAPI.Service;

namespace RfidAPI.Controllers
{
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("add")]
        public ActionResult<string> Create(User user)
        {
            if (string.IsNullOrEmpty(user.UserName.Trim()))
            {
                return "name can't be null";
            }

            var result = _userService.CreateUser(user);
            if (result)
            {
                return "create successfully";
            }
            else
            {
                return "create unsuccessfully";
            }
        }

        [HttpGet]
        [Route("getAll")]
        public Task<ActionResult<IEnumerable<User>>> Gets()
        {
            return _userService.GetUsers();
        }
    }
}