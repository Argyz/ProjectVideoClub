using Entity;
using Service.ServiceClient.DTOs;
using System.Collections.Generic;

namespace Service.ServiceClient.IServiceClient
{
    public interface IClientService
    {
        void Agregar(ClientDto dto);
        void Eliminar(long id);
        void Modificar(ClientDto dto);
        bool findClient(int id);
        ClientDto getClient(int id);
        List<ClientDto> getClients();
    }
}
