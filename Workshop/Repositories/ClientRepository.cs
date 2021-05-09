using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Workshop.DataAccess;
using Workshop.Entities;
using Workshop.Interfaces.Repositories;
using Workshop.Repositories.Base;
using Workshop.Utils;

namespace Workshop.Repositories
{
    public class ClientRepository : RepositoryBase<Client>, IClientRepository
    {
        public ClientRepository(CarContext context) : base(context) { }

        public async Task<Client> GetClient(Guid id)
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