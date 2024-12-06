using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using MVCMovie.Data.Entities;
using MVCMovie.ViewModels;

namespace MVCMovie.Services;

public class MovieService : IMovieService
{
    private readonly MvcMovieContext _context;
    private readonly IMapper _mapper;

    public MovieService(MvcMovieContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<Movie> Create(MovieRequest request)
    {
        var movie = _mapper.Map<Movie>(request);
        _context.Add(movie);
        await _context.SaveChangesAsync();

        return movie;
    }

    public async Task<bool> Delete(int id)
    {
        var movie = await _context.Movie.FindAsync(id);
        if (movie != null)
        {
            _context.Movie.Remove(movie);
        }

        await _context.SaveChangesAsync();

        return true;
    }

    public async Task<MovieViewModel> GetMovie(int id)
    {
        var movie = await _context.Movie
                .FirstOrDefaultAsync(m => m.Id == id);

        return _mapper.Map<MovieViewModel>(movie);
    }

    public async Task<IEnumerable<MovieViewModel>> GetMovies()
    {
        var movies = await _context.Movie.ToListAsync();
        return _mapper.Map<IEnumerable<MovieViewModel>>(movies);
    }

    public bool MovieExists(int id)
    {
        return _context.Movie.Any(e => e.Id == id);
    }

    public async Task<bool> Update(int id, MovieViewModel movie)
    {
        _context.Update(_mapper.Map<Movie>(movie));
        await _context.SaveChangesAsync();

        return true;
    }
}