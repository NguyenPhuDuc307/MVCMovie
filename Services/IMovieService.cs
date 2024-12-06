using MVCMovie.Data.Entities;
using MVCMovie.ViewModels;

namespace MVCMovie.Services;

public interface IMovieService
{
    Task<IEnumerable<MovieViewModel>> GetMovies();
    Task<MovieViewModel> GetMovie(int id);
    Task<Movie> Create(MovieRequest request);
    Task<bool> Update(int id, MovieViewModel movie);
    Task<bool> Delete(int id);
    bool MovieExists(int id);
}