using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RfidAPI.Data;
using RfidAPI.Models;

namespace RfidAPI.Service
{
    public class EquipmentServiceImpl :EquipmentService
    {
        public DataContext _Context;
        public EquipmentServiceImpl(DataContext context)
        {
            _Context = context;
        }

        public bool CreateDevice(Equipment equipment)
        {
            _Context.Equipments.Add(equipment);
            return _Context.SaveChanges() > 0;
        }

        public async Task<ActionResult<IEnumerable<Equipment>>> getAllDivices()
        {
            return await _Context.Equipments.ToListAsync();
        }
    }
}