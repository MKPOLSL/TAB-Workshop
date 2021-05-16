using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Workshop.Dtos;
using Workshop.Entities;
using Workshop.Interfaces.Services.Base;

namespace Workshop.Interfaces
{
    public interface IClientService : IServiceBase<Client>
    {
        Task<Client> GetClientById(Guid id);
    }
}
