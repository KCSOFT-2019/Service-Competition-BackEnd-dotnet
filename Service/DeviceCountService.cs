using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RfidAPI.Models;

namespace RfidAPI.Service
{
    public interface DeviceCountService
    {
        bool addDevice(string deviceName);
        
        Task<ActionResult<IEnumerable<DeviceCount>>> getAllDiviceCount();
    }
}