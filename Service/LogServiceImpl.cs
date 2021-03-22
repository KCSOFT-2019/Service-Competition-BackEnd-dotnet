using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RfidAPI.Data;
using RfidAPI.Models;

namespace RfidAPI.Service
{
    public class LogServiceImpl : LogService
    {
        public DataContext _Context;
        public LogServiceImpl(DataContext context)
        {
            _Context = context;
        }

        public bool CreateLog(Log log)
        {
            _Context.Logs.Add(log);
            return _Context.SaveChanges() > 0;
        }

        public async Task<ActionResult<IEnumerable<Log>>> getAllResult()
        {
            return await _Context.Logs.ToListAsync();
        }

       

        public bool PutBorrowRequest(string faceinfo, int from_id, string device_UID, DateTime from_time, DateTime to_time, int status, string log)
        {

            var to_id = _Context.Users.SingleOrDefault(s => s.faceInfo == faceinfo).UserId;
            
            var logg = new Log();
            logg.from_UserId = from_id;
            logg.to_UserId = to_id;
            logg.from_time = from_time;
            logg.to_time = to_time;
            logg.requestStatus = RequestStatus.ok;
            logg.status = status;
            logg.log = log;

            _Context.Logs.Add(logg);
            return _Context.SaveChanges() > 0;



        }

        public bool PutBorrowRequest(int to_id, int from_id, string device_UID, DateTime from_time, DateTime to_time, int status, string log)
        {
            //var to_id = _Context.Users.SingleOrDefault(s => s.faceInfo == faceinfo).UserId;
            
            var logg = new Log();
            logg.from_UserId = from_id;
            logg.to_UserId = to_id;
            logg.from_time = from_time;
            logg.to_time = to_time;
            logg.requestStatus = RequestStatus.notYet;
            logg.status = status;
            logg.log = log;

            _Context.Logs.Add(logg);
            return _Context.SaveChanges() > 0;

        }
    }
}