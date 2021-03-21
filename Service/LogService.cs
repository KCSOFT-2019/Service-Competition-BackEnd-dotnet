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
    }
}