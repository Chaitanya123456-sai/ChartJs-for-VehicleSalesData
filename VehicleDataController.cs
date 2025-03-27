using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic; 
using System.Threading.Tasks;     
using VehicleAPI.Data;
using VehicleAPI.Models;

namespace VehicleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleDataController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public VehicleDataController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<VehicleData>>> GetVehicleData()
        {
            return await _context.VehicleData.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<VehicleData>> PostVehicleData(VehicleData vehicle)
        {
            _context.VehicleData.Add(vehicle);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetVehicleData), new { id = vehicle.Id }, vehicle);
        }
    }
}
