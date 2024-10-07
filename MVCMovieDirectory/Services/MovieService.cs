namespace MVCMovieDirectory.Services;

public class MovieService : IMovieService
{
    private readonly IList<Movie> _movies = [
            new Movie(1, "The Shawshank Redemption", 1994, 9.3m),
            new Movie(2, "The Godfather", 1972, 9.2m),
            new Movie(3, "The Dark Knight", 2008, 9.0m),
            new Movie(4, "The Godfather Part II", 1974, 9.0m),
            new Movie(5, "12 Angry Men", 1957, 9.0m),
            new Movie(6, "Schindler's List", 1993, 9.0m),
            new Movie(7, "The Lord of the Rings: The Return of the King", 2003, 9.0m),
            new Movie(8, "Pulp Fiction", 1994, 8.9m),
            new Movie(9, "The Lord of the Rings: The Fellowship of the Ring", 2001, 8.9m),
            new Movie(10, "The Good, the Bad and the Ugly", 1996, 8.8m),
            new Movie(11, "Forrest Gump", 1994, 8.8m),
            new Movie(12, "The Lord of the Rings: The Two Towers", 2002, 8.8m),
            new Movie(13, "Fight Club", 1999, 8.8m),
            new Movie(14, "Inception", 2010, 8.8m),
            new Movie(15, "Star Wars: Episode V - The Empire Strikes Back", 1980, 8.7m),
            new Movie(16, "The Matrix", 1999, 8.7m),
            new Movie(17, "Goodfellas", 1990, 8.7m),
            new Movie(18, "One Flew Over the Cuckoo's Nest", 1975, 8.7m),
            new Movie(19, "Se7en", 1995, 8.6m),
            new Movie(20, "Interstellar", 2014, 8.5m),
        ];

    public IEnumerable<Movie> GetBestMovies()
    {
        return _movies
            .OrderByDescending(movie => movie.Rating)
            .ToList();
    }

    public Movie GetMovie(int movieId)
    {
        return _movies.Single(movie => movie.MovieId == movieId);
    }

    public void AddMovie(Movie movie)
    {
        var movieId = _movies.Max(movie => movie.MovieId) + 1;
        var newMovie = new Movie(movieId, movie.Title, movie.Year, movie.Rating);
        _movies.Add(newMovie);
    }
}

