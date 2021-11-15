using Service.ServiceMovie.IServiceMovie;
using Service.ServiceMovie.DTOs;
using Data;
using Entity;
using System;
using System.Linq;

namespace Service.ServiceMovie
{
    public class MovieService : IMovieService
    {
        private StockMovie movieRecup;
        private MovieDto dtoReturn;

        public MovieService()
        {
            dtoReturn = new MovieDto();
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

        public void getMovies()
        {
            throw new System.NotImplementedException();
        }

       
    }
}
