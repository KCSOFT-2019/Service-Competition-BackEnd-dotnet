using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RfidAPI.Service
{
    public interface Equipment
    {
        bool CreateDevice(Equipment equipment);

        Task<ActionResult<IEnumerable<Equipment>>> getAllDivices();
    }
}