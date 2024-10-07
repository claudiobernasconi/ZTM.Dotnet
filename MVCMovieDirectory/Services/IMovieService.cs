namespace MVCMovieDirectory.Services;
public interface IMovieService
{
    IEnumerable<Movie> GetBestMovies();
    Movie GetMovie(int movieId);
    void AddMovie(Movie movie);
}
