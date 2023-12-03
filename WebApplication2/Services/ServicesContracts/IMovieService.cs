
using WebApplication2.Models;

namespace WebApplication2.Services.ServicesContracts
{
    public interface IMovieService
    {

        public List<Movie> getMoviesByGenreName(string genre);
        public List<Movie> getMoviesOrderedByName();

        public List<Movie> getMoviesByGenreID(int id);

    }
}