using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "DDLJ" };
            return View(movie);
        }
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            if(User.IsInRole(RoleName.CanManageMovie))
                return View("Index");

            return View("ReadOnlyList");

        }
       public ActionResult ByReleaseDate(int year,int month)
        {
            return Content(year + "/" + month);
        }
        [Authorize(Roles=RoleName.CanManageMovie)]
        public ActionResult NewMovie()
        {
                var c = _context.genres.ToList();
                var viewmodel = new ViewModel.RandomMovieViewModel
                {
                    Genres = c
                };
                return View(viewmodel);
            }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanManageMovie)]
        public ActionResult Save(Movie movie)
        {
            //if (!ModelState.IsValid)
            //{
            //    var viewModel = new RandomMovieViewModel(movie)
            //    {
            //        Genres = _context.genres.ToList()
            //    };

            //    return View("NewMovie", viewModel);
            //}

            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
                movie.NumberAvailable = movie.NumberInStock;
                _context.movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.movies.Single(m => m.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.GenreId = movie.GenreId;
                movie.NumberAvailable = movie.NumberInStock;
                movieInDb.ReleaseDate = movie.ReleaseDate;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }
    }
}