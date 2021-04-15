using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using RfidAPI.Data;
using RfidAPI.Models;

namespace RfidAPI.Service
{
    public class DeviceCountServiceImpl : DeviceCountService
    {
        public LibraryDbContext _Context;//DataContext _Context;

        public DeviceCountServiceImpl(LibraryDbContext dataContext)
        {
            _Context = dataContext;
        }

        public bool addDevice(string deviceName)
        {
           
            var device = _Context.DeviceCounts.SingleOrDefault(s => s.deviceName == deviceName);
            if (device == null)
            {
                _Context.DeviceCounts.Add(new DeviceCount
                {
                    deviceCountId = null,
                    deviceName = deviceName,
                    nowCount = 1,
                    totalCount = 1
                });
                

            }
            else
            {
                device.totalCount += 1;
                device.nowCount += 1;
                
            }

            if (_Context.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<ActionResult<IEnumerable<DeviceCount>>> getAllDiviceCount()
        {
            return await _Context.DeviceCounts.ToListAsync();
        }
    }
}