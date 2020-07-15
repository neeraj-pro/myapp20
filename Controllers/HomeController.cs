using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvc_runtime_example.Models;

namespace mvc_runtime_example.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Getdata(AccountModel acc)
        {
            // string fname    = acc.fname;
            // string lname    = acc.lname;
            // string email    = acc.email;
            // string mobile   = acc.mobile;
            // string state    = acc.state;
            // string city     = acc.city;
            // string pincode  = acc.pincode;
            // string password = acc.password;

            ViewBag.Message = acc;

            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
