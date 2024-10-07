using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCMovieDirectory.Models;
using MVCMovieDirectory.Services;

namespace MVCMovieDirectory.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMovieService _movieService;

        public HomeController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        public IActionResult Index()
        {
            var movies = _movieService.GetBestMovies();
            var indexViewModel = new IndexViewModel(movies);

            return View(indexViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
