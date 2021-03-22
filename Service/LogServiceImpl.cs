using System.Collections.Generic;
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
    }
}