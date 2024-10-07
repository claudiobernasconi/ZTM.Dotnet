using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieDictionary.Movies;

namespace MovieDictionary.Pages;

public class IndexModel : PageModel
{
    private readonly IMovieService _movieService;

    public IEnumerable<Movie> Movies { get; set; }

    public IndexModel(IMovieService movieService)
    {
        _movieService = movieService;
    }

    public void OnGet()
    {
        Movies = _movieService.GetBestMovies();
    }
}
