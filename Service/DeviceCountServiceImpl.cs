using System.Collections.Generic;
using System.Collections.Immutable;
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

        public bool addDevice(string deviceName, string url)
        {
           
            var device = _Context.DeviceCounts.SingleOrDefault(s => s.deviceName == deviceName);
            if (device == null)
            {
                _Context.DeviceCounts.Add(new DeviceCount
                {
                    deviceCountId = null,
                    deviceName = deviceName,
                    nowCount = 1,
                    totalCount = 1,
                    imageUrl = url
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
        
        public async Task<ActionResult<IEnumerable<DeviceCount>>> getDiviceCountByName(string name)
        {
            
            
            /*var device = _Context.DeviceCounts.Find().ToList();*/ //SingleOrDefault(s => s.deviceName == name);
            return await _Context.DeviceCounts.Where(b => b.deviceName.Contains(name)).ToListAsync();
        }
    }
}