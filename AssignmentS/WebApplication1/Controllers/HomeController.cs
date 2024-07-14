using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.DTO;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public BusBooking context = null;

        public HomeController(BusBooking _context)
        {
            context = _context;
        }


        public IActionResult Index()
        {
            return View(context.buses.ToList());
        }

        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Registration(User user)
        {
            context.users.Add(user);
            context.SaveChanges();
            return Redirect("/Home/Index");
        }

        public IActionResult Login() 
        {
            return View();
        }
        public IActionResult Loggin(LoginDTO DTO) 
        {
           var list= context.users.ToList();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Username.Equals(DTO.UserName) && list[i].Password.Equals(DTO.Password))
                {
                    return Redirect("/Home/Index");
                }
                else
                {
                    return View();
                }
            }
            return Redirect("/Home/Index");
        }
        public IActionResult Seat(int? id) {
            return View();
        }


    }
}
