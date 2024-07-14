using BusBookingSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BusBookingSystem.Controllers
{
    [Authorize]
    public class BusesController : Controller
    {
        public ApplicationDbContext _context = null;

        public BusesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Buses/AvailableSeats/5
        public async Task<IActionResult> AvailableSeats(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bus = await _context.Buses
                .Include(b => b.Seats)
                .FirstOrDefaultAsync(m => m.BusId == id);

            if (bus == null)
            {
                return NotFound();
            }

            return View(bus);
        }
    }

}
