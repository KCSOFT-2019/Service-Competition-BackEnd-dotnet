using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RfidAPI.Models;
using RfidAPI.Service;

namespace RfidAPI.Controllers
{
    
    public class DeviceCountController : ControllerBase
    {
        private readonly DeviceCountService _deviceCountService;

        public DeviceCountController(DeviceCountService deviceCountService)
        {
            _deviceCountService = deviceCountService;
        }

        [HttpGet("api/deviceCount")]
        public async Task<ActionResult<IEnumerable<DeviceCount>>> GetAll()
        {
            return await _deviceCountService.getAllDiviceCount();
        }

        [HttpPost("api/deviceCount/add")]
        public ActionResult<string> add(string deviceName, string url)
        {
            var res = _deviceCountService.addDevice(deviceName, url);
            if (res)
            {
                return "设备数量添加成功";
            }
            else
            {
                return "设备数量添加失败";
            }
        }
        
        [HttpPost("api/deviceCount/name")]
        public async Task<ActionResult<IEnumerable<DeviceCount>>> GetByName([FromBody]string name)
        {
            return await _deviceCountService.getDiviceCountByName(name);
        }
        
    }
}