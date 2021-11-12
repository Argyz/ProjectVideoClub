using Data;
using Entity;
using Service.ServiceClient.DTOs;

namespace Service.ServiceClient
{
    public class ClientService
    {
        public void Agregar(ClientDto dto)
        {
            using (var ctx = new VideoContext())
            {
                var cliente = new Client();
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
