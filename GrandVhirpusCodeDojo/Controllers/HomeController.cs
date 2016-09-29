using GrandVhirpusCodeDojo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GrandVhirpusCodeDojo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }

        [HttpGet]
        public ViewResult RegistrationForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RegistrationForm(Registration registration)
        {
            if (ModelState.IsValid) { 
            ViewBag.DisplayDate = DateTime.Now.AddDays(20).ToString("dd/mm/yyyy");
                          return View("ThankYou", registration);
            }
            else
            {
                return View();
            }
        }
    }
}