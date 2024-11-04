using Mia_OWP_FINALNI.Models;//dodaje se
using Mia_OWP_FINALNI.ViewModels;//dodaje se
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mia_OWP_FINALNI.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "How to Lose a Guy in Ten Days" };

            var customers = new List<Customer> {
            //moglo je i putem konstruktora
                new Customer{ Name="Customer1"},
                new Customer { Name="Customer2"}
            };

            var viewModel = new RandomMovieViewModel
            {//instanca klase RandomMovieViewModel

                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        //return Content("Hello World!");
        //return HttpNotFound();
        //return new EmptyResult();
        //return RedirectToAction("Index", "Home", new { page = 1, sortBy ="name"}) ;


        public ActionResult Edit(int id)
        {
            return Content("id= " + id);

            //https://localhost:44373/movies/edit/1 hvatanja rute
        }


        /* public ActionResult Index(int?pageIndex,string sortBy) {//index crveni kad nema return-vi vracamo Content/ispis

             if (!pageIndex.HasValue) {

                 //provera da li je razlicito od null-kada je broj null se ulazi u if ako imamo uzvicnik
                 pageIndex = 1;
             }

             if (string.IsNullOrWhiteSpace(sortBy)) {
                 sortBy = "Name";
             }

             return Content(String.Format("pageIndex{0}&sortBy{1}", pageIndex, sortBy));
         }

            [Route("movies/released{year}/{month:regex(\\d{2}):range(1,12)}")]
         public ActionResult ByReleaseDate (int year, int month)
         {
             return Content(year+"/"+month);

 }
        */

        public ViewResult Index()
        {

            var movies = GetMovies();
            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {//kada budemo imali bazu, ovde ce biti u zagradi Lista

            return new List<Movie> { //privremena staticka lista

                new Movie { Id=1,Name="Shrek"},
                new Movie { Id=2,Name="Up"}

            };
        }
    }
}





