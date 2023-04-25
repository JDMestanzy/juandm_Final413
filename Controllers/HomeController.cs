using juandm_Final413.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace juandm_Final413.Controllers
{
    public class HomeController : Controller
    {
        private IEntertainmentAgencyRepository repo;
        public HomeController(IEntertainmentAgencyRepository temp)
        {
            repo = temp;
        }
        public IActionResult DataList()
        {
            var blah = repo.Entertainers.ToList();
            return View(blah);
        }
        [HttpGet]
        public IActionResult AddRecord()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddRecord(Entertainers Entertainer)
        {
            if (ModelState.IsValid)
            {
                repo.Add(Entertainer);
                return RedirectToAction("DataList", Entertainer);
            }
            else
            {
                return View("Index");
            }
        }
        public IActionResult Details(int id)
        {
            // Retrieve the Entertainer with the given ID from the database
            var entertainer = repo.Entertainers.FirstOrDefault(e => e.EntertainerId == id);

            if (entertainer == null)
            {
                // Handle the case where the Entertainer with the given ID was not found
                return NotFound();
            }

            // Pass the retrieved Entertainer to a view that displays all the fields
            return View(entertainer);
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult EditRecord(int entertainerid)
        {
            ViewBag.Entertainers = repo.Entertainers.ToList();
            var record = repo.Entertainers.Single(x => x.EntertainerId== entertainerid);
            return View("EditRecord", record);
        }
        [HttpPost]

        public IActionResult EditRecord(Entertainers entertainer)
        {
            if (ModelState.IsValid)
            {
                repo.Update(entertainer);
                return RedirectToAction("DataList");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        [HttpGet]
        public IActionResult DeleteRecord(int entertainerid)
        {
            var record = repo.Entertainers.Single(x => x.EntertainerId == entertainerid);
            return View(record);
        }
        [HttpPost]
        public IActionResult DeleteRecord(Entertainers entertainer)
        {
            repo.Delete(entertainer);
            return RedirectToAction("DataList");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
