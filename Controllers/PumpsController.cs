using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Collections.Generic;
using CNGFinder.Data;
using CNGFinder.Models;
using CNGNavigator.Models.DTOs;

[ApiController]
[Route("api/pump")]
public class PumpController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public PumpController(ApplicationDbContext context)
    {
        _context = context;
    }

    // **1. Get Pump Details by ID**
    [HttpGet("{pumpId}")]
    public async Task<IActionResult> GetPumpDetails(long pumpId)
    {
        var pump = await _context.Pumps.FindAsync(pumpId);
        if (pump == null)
            return NotFound(new { message = "Pump not found!" });

        return Ok(pump);
    }

    // **2. Get All Pumps**
    [HttpGet]
    public async Task<IActionResult> GetAllPumps()
    {
        // Join Pumps with Owners to get the location data
        var pumpsWithLocations = await _context.Pumps
            .Join(
                _context.Owners,
                pump => pump.Id,
                owner => owner.Id,  // Assuming Pump.Id matches Owner.Id (or modify based on your relationship)
                (pump, owner) => new PumpWithLocationDto
                {
                    Id = pump.Id,
                    Name = pump.Name,
                    CngAvailable = pump.CngAvailable,
                    CngPressure = pump.CngPressure,
                    EstimatedWaitTime = pump.EstimatedWaitTime,
                    Latitude = owner.Latitude,
                    Longitude = owner.Longitude
                }
            ).ToListAsync();

        return Ok(pumpsWithLocations);
    }


    // **3. Add New Pump**
    [HttpPost("add")]
    public async Task<IActionResult> AddPump([FromBody] Pump pump)
    {
        if (pump == null)
            return BadRequest(new { message = "Invalid pump data!" });

        await _context.Pumps.AddAsync(pump);
        await _context.SaveChangesAsync();
        return Ok(new { message = "Pump added successfully!", pump });
    }

    // **4. Update Pump Status**
    [HttpPost("update")]
    public async Task<IActionResult> UpdatePumpStatus([FromBody] PumpStatusUpdateDto request)
    {
        var pump = await _context.Pumps.FindAsync(request.PumpId);
        if (pump == null)
            return NotFound(new { message = "Pump not found!" });

        pump.CngAvailable = request.CngAvailable;
        pump.CngPressure = request.CngPressure;
        pump.EstimatedWaitTime = request.EstimatedWaitTime;

        await _context.SaveChangesAsync();
        return Ok(new { message = "Pump status updated successfully!" });
    }

    // **5. Delete Pump**
    [HttpDelete("delete/{pumpId}")]
    public async Task<IActionResult> DeletePump(long pumpId)
    {
        var pump = await _context.Pumps.FindAsync(pumpId);
        if (pump == null)
            return NotFound(new { message = "Pump not found!" });

        _context.Pumps.Remove(pump);
        await _context.SaveChangesAsync();
        return Ok(new { message = "Pump deleted successfully!" });
    }
}
