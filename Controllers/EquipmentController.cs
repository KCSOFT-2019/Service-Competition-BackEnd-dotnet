using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RfidAPI.Models;
using RfidAPI.Service;

namespace RfidAPI.Controllers
{
    public class EquipmentController : ControllerBase
    {
        private readonly EquipmentService _equipmentService;


        public EquipmentController(EquipmentService equipmentService)
        {
            _equipmentService = equipmentService;
        }

        [HttpPost]
        [Route("api/equipment/add")]
        public ActionResult<string> Create(Equipment equipment)
        {
            var result = _equipmentService.CreateDevice(equipment);
            if (result) return "Equipment create successfully";
            else return "Equipment create unsuccesfully";
        }
        [HttpGet]
        [Route("api/equipment")]
        public Task<ActionResult<IEnumerable<Equipment>>> GetAll()
        {
            return _equipmentService.getAllDivices();
            
        }
    }
}