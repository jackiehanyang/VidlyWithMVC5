using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyWithMVC5.Models;
using VidlyWithMVC5.ViewModel;

namespace VidlyWithMVC5.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            return View();
        }

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name =  "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        // this action will be called when we navigate to movies.
        // in this action, will return a list of movies in the database
        // we can add two optional parameters here, page index and string sortBy
        // if the pageIndex is not specified, we will display the movies in page 1
            // and similiary, if sortBy is not specified, we sort the movies by their name
        // In order to make your parameter optional, we should make it nullable
            // for pageIndex, put question mark to make it a nullable
            // for sortBy we don't have to do anything because the string type in C# is a reference type and it's nullable
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}