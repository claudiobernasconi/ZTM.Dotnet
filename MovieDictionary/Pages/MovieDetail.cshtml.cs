using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieDictionary.Movies;

namespace MovieDictionary.Pages;

public class MovieDetailModel : PageModel
{
    private readonly IMovieService _movieService;
    public Movie Movie { get; set; }

    public MovieDetailModel(IMovieService movieService)
    {
        _movieService = movieService;
    }

    public void OnGet(int movieId)
    {
        Movie = _movieService.GetMovie(movieId);
    }
}
