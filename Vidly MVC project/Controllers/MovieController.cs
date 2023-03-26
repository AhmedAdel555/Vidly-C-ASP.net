using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly_MVC_project.Models;
using Vidly_MVC_project.ViewModels;
using System.Data.Entity;
namespace Vidly_MVC_project.Controllers
{
    public class MovieController : Controller
    {
        private ApplicationDbContext _context;

        public MovieController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult MovieForm()
        {
            List<Genre> genres = _context.Genres.ToList();
            MovieGenre movieGenre = new MovieGenre()
            {
                Movie = new Movie(),
                Genres = genres
            };
            return View(movieGenre);
        }

        public ActionResult Save(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new MovieGenre()
                {
                    Genres = _context.Genres.ToList(),
                    Movie = movie
                };

                return View("MovieForm", viewModel);
            }
            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);
                movieInDb.Title = movie.Title;
                movieInDb.GenreId = movie.GenreId;
                movieInDb.NumberInStocks = movie.NumberInStocks;
                movieInDb.ReleaseDate = movie.ReleaseDate;
            }
            _context.SaveChanges();
            return RedirectToAction("GetAllMovies", "Movie");
        }

        [Route("movies")]
        public ViewResult GetAllMovies()
        {
            List<Movie> movies = _context.Movies.Include(x => x.Genre).ToList();
            return View(movies);
        }

        [Route("movies/details/{Id}")]
        public ActionResult GetMovieDetials(int Id)
        {
            Movie movie = _context.Movies.Include(x => x.Genre).SingleOrDefault(x => x.Id == Id);
            return View(movie);
        }

        [Route("movies/Edit/{Id}")]
        public ActionResult Edit(int Id)
        {
            Movie movie = _context.Movies.Include(x => x.Genre).SingleOrDefault(x => x.Id == Id);
            List<Genre> genres = _context.Genres.ToList();
            MovieGenre movieGenre = new MovieGenre()
            {
                Movie = movie,
                Genres = genres
            };
            return View("MovieForm", movieGenre);
        }
    }
}