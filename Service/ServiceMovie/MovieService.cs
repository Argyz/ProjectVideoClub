using Service.ServiceMovie.IServiceMovie;
using Service.ServiceMovie.DTOs;
using Data;
using Entity;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Service.ServiceMovie
{
    public class MovieService : IMovieService
    {
        private StockMovie movieRecup;
        private MovieDto dtoReturn;
        private MovieDto dto;
        private List<MovieDto> movieDtos;
        private List<StockMovie> movies;
        public MovieService()
        {
            dtoReturn = new MovieDto();
            movieDtos = new List<MovieDto>();
            movies = new List<StockMovie>();    
        }
        public void Agregar(MovieDto dto)
        {
            using (var ctx = new VideoContext())
            {
                var movieNew = new StockMovie() { Name = dto.Name, Gender = dto.Gender, Date = dto.Date, Amount=dto.Amount,Removed = false };
                ctx.StockMovies.Add(movieNew);
                ctx.SaveChanges();
            }
        }

        public void Eliminar(int id)
        {
            using (var ctx = new VideoContext())
            {
                var movie = ctx.StockMovies.Find(id);

                movie.Removed = true;
                ctx.SaveChanges();
            }
        }

        public void Modificar(MovieDto dto)
        {
            using (var ctx = new VideoContext())
            {
                var movie = ctx.StockMovies.Find(dto.Id);

                movie.Name = dto.Name;
                movie.Gender = dto.Gender;
                movie.Date = dto.Date;
                movie.Amount = dto.Amount;

                ctx.SaveChanges();
            }
        }

        public bool FindMovie(int id)
        {
            using (var ctx = new VideoContext())
            {
                var movie = ctx.StockMovies.Find(id);

                if (movie == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        public MovieDto getPelicula(int id)
        {
           
            using (var ctx = new VideoContext())
            {
                movieRecup = ctx.StockMovies.Find(id);             
            }

            dtoReturn.Name = movieRecup.Name;
            dtoReturn.Gender = movieRecup.Gender;
            dtoReturn.Date = movieRecup.Date;
            dtoReturn.Amount = movieRecup.Amount;

            return dtoReturn;
            
        }

        public List<MovieDto> getMovies()
        {
            using (var ctx = new VideoContext())
            {
                movies = ctx.StockMovies.Where(x=>x.Removed==false).ToList();
            }

            foreach (var item in movies)
            {
                dto = new MovieDto() { Id = item.Id, Name = item.Name, Gender=item.Gender, Date=item.Date, Amount=item.Amount};
                movieDtos.Add(dto);
            }

            return movieDtos;
        }

    }
}
