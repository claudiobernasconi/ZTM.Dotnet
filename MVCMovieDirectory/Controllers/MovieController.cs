using Microsoft.AspNetCore.Mvc;
using MVCForms.Models;
using MVCMovieDirectory.Models;
using MVCMovieDirectory.Services;

namespace MVCMovieDirectory.Controllers;

public class MovieController : Controller
{
    private readonly IMovieService _movieService;

    public MovieController(IMovieService movieService)
    {
        _movieService = movieService;
    }

    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(AddMovieViewModel movieViewModel)
    {
        if (ModelState.IsValid)
        {
            // Process the data (e.g., save to the database) and redirect to a success page
            var movieId = _movieService.GetBestMovies().Max(movie => movie.MovieId) + 1;
            var movie = new Movie(movieId, movieViewModel.Title, movieViewModel.Year, movieViewModel.Rating);
            _movieService.AddMovie(movie);

            return RedirectToAction("Added");
        }

        return View(movieViewModel);
    }

    public IActionResult Added()
    {
        return View();
    }

    public IActionResult Detail(int movieId)
    {
        var movie = _movieService.GetMovie(movieId);
        var movieDetailViewModel = new MovieDetailViewModel(movie);

        return View(movieDetailViewModel);
    }
}
