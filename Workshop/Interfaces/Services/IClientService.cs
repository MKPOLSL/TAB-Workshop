using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop.Dtos;

namespace Workshop.Interfaces
{
    public interface IClientService
    {
        Task AddClient(ClientCreateDto client);
    }
}
