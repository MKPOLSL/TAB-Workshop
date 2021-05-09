using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop.DataAccess;
using Workshop.Dtos;
using Workshop.Entities;
using Workshop.Interfaces;
using Workshop.Services.Base;
using Workshop.Utils;

namespace Workshop.Services
{
    public class ClientService : ServiceBase<Client>, IClientService
    {
        public ClientService(CarContext context) : base(context) { }

        public async Task AddClient(ClientCreateDto client)
        {
            var newClient = new Client
            {
                Id = Guid.NewGuid(),
                FirstName = client.FirstName,
                LastName = client.LastName,
                PhoneNumber = client.PhoneNumber
            };
            await CreateAsync(newClient);
        }

        public async Task<Client> GetClientById(Guid id)
        {
            return await Context
                  .Set<Client>()
                  .GetAllNotHidden()
                  .Include(c => c.Cars)
                  .Where(c => c.Id == id)
                  .FirstOrDefaultAsync();
        }
    }
}
