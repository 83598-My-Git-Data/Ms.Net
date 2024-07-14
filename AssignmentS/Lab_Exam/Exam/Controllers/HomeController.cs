using Exam.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Exam.Controllers
{
    public class HomeController : Controller
    {
            
        public KDACDBContext context = null;

        public HomeController(KDACDBContext _context)
        {
            context = _context;
        }

        public IActionResult Index()
        {
            return View();
        }

        
    }
}
