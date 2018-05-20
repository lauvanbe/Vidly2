using System.Collections.Generic;
using System.Web.Mvc;
using Vidly2.Models;
using Vidly2.ViewModel;

namespace Vidly2.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Shrek!"};
            var customers = new List<Customer>()
            {
                new Customer() {Name = "customer1"},
                new Customer() {Name = "customer2"}
            };

            var ViewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(ViewModel);
        }

        [Route("Movies/Index")]
        public ActionResult Index()
        {
            var movie = new List<Movie>()
            {
                new Movie() {Name = "Die Hard"},
                new Movie() {Name = "GoostBosters"}
            };
            return View(movie);
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}