using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicianApp.Models;

namespace MusicianApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ReadAllCookkies();
          
            return View();
        }

        public IActionResult About()
        {
            ReadAllCookkies();
            return View();
        }

        public IActionResult Contact()
        {
            ReadAllCookkies();
            return View();
        }

        public IActionResult Privacy()
        {
            ReadAllCookkies();
            return View();
        }

        private void ReadAllCookkies()
        {
            ViewData["memberStatus"] = Request.Cookies["memberStatus"];
            ViewData["idCookie"] = Request.Cookies["idCookie"];
            ViewData["firstNameCookie"] = Request.Cookies["firstNameCookie"];
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            ReadAllCookkies();
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
