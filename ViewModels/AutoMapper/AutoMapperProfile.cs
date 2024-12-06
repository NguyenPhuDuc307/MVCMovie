using AutoMapper;
using MVCMovie.Data.Entities;

namespace MVCMovie.ViewModels.AutoMapper
{

    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Movie, MovieViewModel>();
            CreateMap<MovieViewModel, Movie>();
            CreateMap<MovieRequest, Movie>();
        }
    }
}