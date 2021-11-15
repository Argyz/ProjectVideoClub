using Data;
using Entity;
using Service.ServiceClient.DTOs;
using Service.ServiceClient.IServiceClient;
using System.Linq;

namespace Service.ServiceClient
{
    public class ClientService : IClientService
    {
        private Client client1;
        private ClientDto dtoreturn;

        public ClientService()
        {
            dtoreturn = new ClientDto();
        }
        public void Agregar(ClientDto dto)
        {
            using (var ctx = new VideoContext())
            {
                var cliente = new Client() { Name=dto.Name, LastName=dto.LastName,Removed=false};
                  
                ctx.Clients.Add(cliente);
                ctx.SaveChanges();
            }

            using (var ctx=new VideoContext())
            {
                var cliente = ctx.Clients.Where(x => x.Name == dto.Name).FirstOrDefault();

                var movie = new Movement() { Name = dto.Pelicula, Client = cliente };

                ctx.Movements.Add(movie);
                ctx.SaveChanges();
            }
        }

        public void Eliminar(long id)
        {
            using (var ctx = new VideoContext())
            {
                var cliente = ctx.Clients.Find(id);
                cliente.Removed = true;
                ctx.SaveChanges();
            }
        }

        public bool findClient(int id)
        {
            using (var ctx = new VideoContext())
            {
                var client = ctx.Clients.Find(id);

                if (client == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public void Modificar(ClientDto dto)
        {
            using (var ctx = new VideoContext())
            {
                var client = ctx.Clients.Find(dto.Id);

                client.Name = dto.Name;
                client.LastName= dto.LastName;
                

                ctx.SaveChanges();
            }
        }

        public ClientDto getClient(int id)
        {
            using (var ctx=new VideoContext())
            {
                client1 = ctx.Clients.Find(id);
            }

            dtoreturn.Name = client1.Name;
            dtoreturn.LastName = client1.LastName;
            

            return dtoreturn;
        }

        public void getClients()
        {
            throw new System.NotImplementedException();
        }

        
    }
}
