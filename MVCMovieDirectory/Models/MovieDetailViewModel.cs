using MVCMovieDirectory.Services;

namespace MVCMovieDirectory.Models;

public class MovieDetailViewModel
{
    public string Title { get; set; }
    public decimal Rating { get; set; }
    public int Year { get; set; }
    public string ImageUrl { get; set; }
    public string PageTitle { get; set; }

    public MovieDetailViewModel(Movie movie)
    {
        Title = movie.Title;
        PageTitle = movie.Title;
        Rating = movie.Rating;
        Year = movie.Year;
        ImageUrl = $"/img/movie_{movie.MovieId}.jpg";
    }
}
