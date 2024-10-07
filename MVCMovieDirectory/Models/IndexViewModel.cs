using MVCMovieDirectory.Services;

namespace MVCMovieDirectory.Models;

public class IndexViewModel
{
    public IEnumerable<Movie> Movies { get; set; }

    public IndexViewModel(IEnumerable<Movie> movies)
    {
        Movies = movies;
    }
}
