using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RfidAPI.Models;

namespace RfidAPI.Service
{
    public interface DeviceCountService
    {
        bool addDevice(string deviceName, string url);
        
        Task<ActionResult<IEnumerable<DeviceCount>>> getAllDiviceCount();
        
        Task<ActionResult<IEnumerable<DeviceCount>>> getDiviceCountByName(string name);
    }
}