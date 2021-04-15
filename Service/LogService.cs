using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RfidAPI.Models;

namespace RfidAPI.Service
{
    public interface LogService
    {
        bool CreateLog(Log log);

        Task<ActionResult<IEnumerable<Log>>> getAllResult();

        public bool PutBorrowRequest(int status,string faceinfo, string from_id, string device_UID, DateTime from_time,
            DateTime to_time, string log);
        
        public bool PutBorrowRequest(string to_id, string from_id, string device_UID, DateTime from_time,
            DateTime to_time, int status, string log);
    }
}