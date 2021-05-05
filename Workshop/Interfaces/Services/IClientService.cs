using System.Collections.Generic;
using System.Threading.Tasks;
using Workshop.Dtos;
using Workshop.Entities;

namespace Workshop.Interfaces
{
    public interface IClientService
    {
        Task AddClient(ClientCreateDto client);

        Task<IEnumerable<Client>> GetClients();
    }
}
