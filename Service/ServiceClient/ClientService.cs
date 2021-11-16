using Data;
using Entity;
using Service.ServiceClient.DTOs;
using Service.ServiceClient.IServiceClient;
using System.Collections.Generic;
using System.Linq;

namespace Service.ServiceClient
{
    public class ClientService : IClientService
    {
        private Client client1;
        private ClientDto dtoreturn;
        private Movement movement;
        private ClientDto dto;
        private List<Client> clients;
        private List<ClientDto> clientDtos;
        public ClientService()
        {
            dtoreturn = new ClientDto();
            clients = new List<Client>();
            clientDtos = new List<ClientDto>();
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

            using (var ctx=new VideoContext())
            {
                var movement = ctx.Movements.Where(x => x.Name == dto.Pelicula).FirstOrDefault();
                movement.Name = dto.Pelicula;
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

        public List<ClientDto> getClients()
        {
            using (var ctx = new VideoContext())
            {
               clients=ctx.Clients.Where(x=> x.Removed==false).ToList();
            }

            foreach (var item in clients)
            {
                dto = new ClientDto() { Id=item.Id, Name=item.Name, LastName=item.LastName};
                clientDtos.Add(dto);
            }

            return clientDtos;
            
        }

        
    }
}
