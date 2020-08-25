using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GC_Lab21_MovieRegistration.Models;
using Microsoft.AspNetCore.Http;

namespace GC_Lab21_MovieRegistration.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult MovieRegistration()
        {
            return View(new Movie());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult DisplayMovie(string Movie)
        {
            HttpContext.Session.SetString("MovieSession", Movie);

            return View("Index");
        }

        public IActionResult RemoveMovie()
        {
            HttpContext.Session.Remove("MovieSession");

            return View("Index");
        }
    }
}
