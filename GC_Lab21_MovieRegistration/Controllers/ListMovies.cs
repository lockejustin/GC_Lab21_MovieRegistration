using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using GC_Lab21_MovieRegistration.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GC_Lab21_MovieRegistration.Controllers
{
    public class ListMovies : Controller
    {
        public IActionResult Index(List<Movie> movies)
        {
            
            string movieListJSON = HttpContext.Session.GetString("MovieSession") ?? "EmptySession";
            if (movieListJSON != "EmptySession")
            {
                movies = JsonSerializer.Deserialize<List<Movie>>(movieListJSON);
            }

            return View(movies);
        }
    }
}
