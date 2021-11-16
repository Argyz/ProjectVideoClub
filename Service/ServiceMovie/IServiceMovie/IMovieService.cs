using Service.ServiceMovie.DTOs;
using System.Collections.Generic;

namespace Service.ServiceMovie.IServiceMovie
{
    public interface IMovieService
    {
        void Agregar(MovieDto dto);
        void Eliminar(int id);
        void Modificar(MovieDto dto);
        MovieDto getPelicula(int id);
        List<MovieDto> getMovies();

    }
}
