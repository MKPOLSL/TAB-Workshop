using System;
using System.Threading.Tasks;
using Workshop.DataAccess;
using Workshop.Dtos;
using Workshop.Entities;
using Workshop.Interfaces;

namespace Workshop.Services
{
    public class ClientService : IClientService
    {
        private readonly CarContext context;

        public ClientService(CarContext context)
        {
            this.context = context;
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
    }
}
