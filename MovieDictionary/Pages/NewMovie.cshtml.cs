using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieDictionary.Movies;

namespace MovieDictionary.Pages;

public class NewMovieModel : PageModel
{
    private readonly IMovieService _movieService;

    public Movie Movie { get; set; }

    public NewMovieModel(IMovieService movieService)
    {
        _movieService = movieService;
    }

    public void OnPost(Movie movie)
    {
        _movieService.AddMovie(movie);
        ModelState.Clear();
    }
}
