using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RfidAPI.Models;
using RfidAPI.Service;

namespace RfidAPI.Controllers
{
    public class LogController :ControllerBase
    {
        private readonly LogService _logService;

        public LogController(LogService logService)
        {
            _logService = logService;
        }

        [HttpPost]
        [Route("api/log/borrow")]
        public ActionResult<string> PutBorrowRequest(string to_id, string from_id, string device_UID, DateTime from_time,
            DateTime to_time, int status, string log)
        {
            var result = _logService.PutBorrowRequest( to_id, from_id, device_UID, from_time,
                to_time, status,log);
            if (result)
            {
                return "borrow successfully";

            }
            else return "borrow unsuccessfully";
        }

        [HttpGet]
        [Route("api/log/getAll")]
        public Task<ActionResult<IEnumerable<Log>>> Gets()
        {
           return  _logService.getAllResult();
        }
        
        
    }
}