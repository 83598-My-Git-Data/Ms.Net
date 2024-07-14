using Demo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Demo.Controllers
{
    public class HomeController : Controller
    {
        KDACDBContext Context = null;
        public HomeController(KDACDBContext _context)
        {
            Context = _context;
        }
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            return View("Index", Context.Contacts.ToList());
        }
        public IActionResult Create()
        {
            return View("Create");
        }

        public IActionResult AfterCreate(Contact contact)
        {
            Context.Contacts.Add(contact);
            Context.SaveChanges();
            return Redirect("/Home/Index");
        }

        public IActionResult Edit(int? id)
        {
            Contact empToBeEdited = Context.Contacts.Find(id);
            return View("Edit", empToBeEdited);
        }

        public IActionResult AfterEdit(Contact contact)
        {
            Contact empToBeupdated = Context.Contacts.Find(contact.Id);
            empToBeupdated.FirstName = contact.FirstName;
            empToBeupdated.LastName = contact.LastName;
            empToBeupdated.Address = contact.Address;
            empToBeupdated.MobileNo = contact.MobileNo;
            Context.SaveChanges();
            return Redirect("/Home/Index");
        }
        public IActionResult Delete(int? id)
        {
            Contact empTpDelete = Context.Contacts.Find(id);
            Context.Contacts.Remove(empTpDelete);
            Context.SaveChanges();
            return Redirect("/Home/Index");
        }
        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
