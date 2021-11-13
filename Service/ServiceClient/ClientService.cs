using Data;
using Entity;
using Service.ServiceClient.DTOs;
using System.Linq;

namespace Service.ServiceClient
{
    public class ClientService
    {
        public void Agregar(ClientDto dto)
        {
            using (var ctx = new VideoContext())
            {
                var cliente = new Client() { Name=dto.Name, LastName=dto.LastName,Pelicula=dto.Pelicula,Removed=false};
                  
                ctx.Clients.Add(cliente);
                ctx.SaveChanges();
            }

            using (var ctx=new VideoContext())
            {
                var cliente = ctx.Clients.Where(x => x.Name == dto.Name).FirstOrDefault();

                var movie = new Movie() { Name = dto.Pelicula, Client = cliente };
            }
        }

        public void Eliminar(long id)
        {
            throw new System.NotImplementedException();
        }

        public void getCliente()
        {
            throw new System.NotImplementedException();
        }

        public void Modificar(ClientDto dto)
        {
            throw new System.NotImplementedException();
        }
    }
}
