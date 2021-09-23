using ManhattanMVC.ViewModels;
using ManhattanMVC.Views.Movie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ManhattanMVC.Controllers
{
    public class DefaultController : Controller
    {
        private List<Movie> _movies = new List<Movie>();

        // GET: Default
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Not that Fast and Furious 2" };
            var customers = new List<Customer>
            {
                new Customer{Name="C1"},
                new Customer{Name="C2"},
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }

        // algo asi? no sexd
        public ActionResult ListingMovies()
        {
            var movie1 = new Movie() { Name = "Not that Fast and Furious" };
            var movie2 = new Movie() { Name = "The ring of the lords" };
            var movie3 = new Movie() { Name = "Unterminated 2" };
            _movies.Add(movie1);
            _movies.Add(movie2);
            _movies.Add(movie3);

            var customers = new List<Customer>
            {
                new Customer{Name="C1"},
                new Customer{Name="C2"},
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie1,
                Customers = customers
            };
            return View(viewModel);
        }
    }
}