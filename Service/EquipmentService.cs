using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RfidAPI.Models;
namespace RfidAPI.Service
{
    public interface EquipmentService
    {
        bool CreateDevice(Equipment equipment);

        Task<ActionResult<IEnumerable<Equipment>>> getAllDivices();
    }
}