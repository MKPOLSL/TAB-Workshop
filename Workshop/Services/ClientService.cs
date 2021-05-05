using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Workshop.DataAccess;
using Workshop.Dtos;
using Workshop.Entities;
using Workshop.Interfaces;
using Workshop.Interfaces.Repositories;

namespace Workshop.Services
{
    public class ClientService : IClientService
    {
        private readonly CarContext context;
        private readonly IClientRepository clientRepository;

        public ClientService(CarContext context, IClientRepository clientRepository)
        {
            this.context = context;
            this.clientRepository = clientRepository;
        }

        public async Task AddClient(ClientCreateDto client)
        {
            var newClient = new Client
            {
                Id = Guid.NewGuid(),
                FirstName = client.FirstName,
                LastName = client.LastName,
                PhoneNumber = client.PhoneNumber
            };
            context
                .Set<Client>()
                .Add(newClient);
            await context.SaveChangesAsync();
        }

        public async Task <IEnumerable<Client>>GetClients()
        {
            return await clientRepository.GetAllAsync();
        }

        public async Task DeleteClient(Client client)
        {
            clientRepository.Delete(client);
            await clientRepository.SaveChangesAsync();
        }
    }
}
