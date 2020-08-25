using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GC_Lab21_MovieRegistration.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace GC_Lab21_MovieRegistration.Controllers
{
    public class MovieRegistrationController : Controller
    {
        List<Movie> movieList = new List<Movie>();
        
        public IActionResult Index()
        {
            return View(new Movie());
        }

        public IActionResult MovieSummary(Movie movie)
        {
            string actorAll = movie.Actors[0];
            string directorAll = movie.Directors[0];

            movie.Actors = actorAll.Split(',');
            movie.Directors = directorAll.Split(',');
            
            //checks that the user parameter fits the model aka not missing info/not bad format
            if (ModelState.IsValid)
            {
                string movieListJSON = HttpContext.Session.GetString("MovieSession") ?? "EmptySession";
                if (movieListJSON != "EmptySession")
                {
                    movieList = JsonSerializer.Deserialize<List<Movie>>(movieListJSON);
                }

                movieList.Add(movie);

                movieListJSON = JsonSerializer.Serialize(movieList);

                HttpContext.Session.SetString("MovieSession", movieListJSON);

                return View(movieList); //if valid sends to user view
            }
            else
            {
                return View("Index", movie); //sends incorrect user back to form
            }
        }

    }
}
