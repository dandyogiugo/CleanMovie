using CleanMovie.Application;
using CleanMovie.Domain;

namespace CleanMovie.Infrastructure
{
    public class MovieService : IMovieService
    {
        private readonly string _connectionString;

        public MovieService(string connectionString)
        {
            _connectionString = connectionString;
        }

        static readonly List<Movie> LocalAllMovies = new()
        {
            new Movie {Id = 1, Name = "Black Pantha"},
            new Movie {Id = 2, Name = "Creed III"}
        };

        public List<Movie> GetAllMovies()
        {
            return LocalAllMovies;
        }

        public Movie GetMovieById(int id)
        {
            var movie = LocalAllMovies.FirstOrDefault(x => x.Id.Equals(id));

            if (movie == null) throw new InvalidOperationException("The movie you are looking for does not exist");

            return movie;
        }
    }
}
