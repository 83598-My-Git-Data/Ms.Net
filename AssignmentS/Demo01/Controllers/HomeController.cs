using Demo01.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Demo01.Controllers
{
    public class HomeController : Controller
    {

        KDACDBContext context = null;
        public HomeController(KDACDBContext _context)
        {
            context = _context;
        }

        public IActionResult Index()
        {
            return View("Index", context.Time.ToList());
        }

        public IActionResult Create()
        {
            return View("Create");
        }
        public IActionResult AfterCreate(Time time)
        {
            context.Time.Add(time);
            context.SaveChanges();
            return Redirect("/Home/Index");
        }
        public IActionResult Edit(int? id)
        {
            Time timeToBeEdited = context.Time.Find(id);
            return View("Edit", timeToBeEdited);
        }

        public IActionResult AfterEdit(Time time)
        {
            Time timeToBeupdated = context.Time.Find(time.BatchId);
            timeToBeupdated.Course = time.Course;
            timeToBeupdated.BatchName = time.BatchName;
            timeToBeupdated.GST = time.GST;
            timeToBeupdated.TotalFee = time.TotalFee;
            
            context.SaveChanges();

            return Redirect("/Home/Index");
        }
        public IActionResult Delete(int? id)
        {
            Time empTpDelete = context.Time.Find(id);
            context.Time.Remove(empTpDelete);
            context.SaveChanges();
            return Redirect("/Home/Index");
        }
    }
}
