using Service.ServiceMovie.DTOs;

namespace Service.ServiceMovie.IServiceMovie
{
    public interface IMovieService
    {
        void Agregar(MovieDto dto);
        void Eliminar(int id);
        void Modificar(MovieDto dto);
        void getMovies();

    }
}
