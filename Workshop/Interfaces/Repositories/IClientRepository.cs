using System;
using System.Threading.Tasks;
using Workshop.Entities;
using Workshop.Interfaces.Repositories.Base;

namespace Workshop.Interfaces.Repositories
{
    public interface IClientRepository : IRepositoryBase<Client>
    {
        Task<Client> GetClient(Guid id);
    }
}