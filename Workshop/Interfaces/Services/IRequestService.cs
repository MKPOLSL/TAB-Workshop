using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop.Entities;
using Workshop.Interfaces.Services.Base;

namespace Workshop.Interfaces.Services
{
    public interface IRequestService : IServiceBase<Request>
    {
        Task<Request> GetRequest(Guid id);
        Task<IEnumerable<Request>> GetAllRequests();
    }
}
