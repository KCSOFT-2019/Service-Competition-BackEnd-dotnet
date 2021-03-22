using System;
using Microsoft.AspNetCore.Mvc;
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
        public ActionResult<string> PutBorrowRequest(string faceinfo, int from_id, string device_UID, DateTime from_time,
            DateTime to_time, int status, string log)
        {
            var result = _logService.PutBorrowRequest(faceinfo, from_id, device_UID, from_time,
                to_time, status, log);
            if (result)
            {
                return "borrow successfully";

            }
            else return "borrow unsuccessfully";
        }
        
    }
}