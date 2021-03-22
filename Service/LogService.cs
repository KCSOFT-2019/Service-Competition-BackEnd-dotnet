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

        public bool PutBorrowRequest(string faceinfo, int from_id, string device_UID, DateTime from_time,
            DateTime to_time, int status, string log);
        
        public bool PutBorrowRequest(int to_id, int from_id, string device_UID, DateTime from_time,
            DateTime to_time, int status, string log);
    }
}