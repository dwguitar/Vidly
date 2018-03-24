using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {

            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);           
        }

        public ActionResult Edit(int movieId)
        {
            return Content("id=" + movieId);

        }

        public ActionResult Index(int? pagIndex, string sortBy)
        {
            if (!pagIndex.HasValue)
                pagIndex = 1;
            if (String.IsNullOrEmpty(sortBy))            
                sortBy = "Name";

            return Content(String.Format("PageIndex={0}&={1}", pagIndex, sortBy));

           
        }
    }
}