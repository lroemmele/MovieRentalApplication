using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieRentalApp.Models;
using MovieRentalApp.ViewModels;

namespace MovieRentalApp.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Moives
        public ActionResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }



        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek" },
                new Movie { Id = 2, Name = "Wall-e" }
            };
        }
    }
}