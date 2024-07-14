using BusBookingSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace BusBookingSystem.Controllers
{
    public class UsersController : Controller
    {
        public ApplicationDbContext _context = null;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Users/Register
        public IActionResult Register()
        {
            return View();
        }

        // POST: Users/Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return RedirectToAction(nameof(Login));
            }
            return View(user);
        }

        // GET: Users/Login
        public IActionResult Login()
        {
            return View();
        }

        // POST: Users/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(string email, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
            if (user != null)
            {
                user.IsLoggedIn = true;
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            return View();
        }
    }
}
