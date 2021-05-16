using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop.DataAccess;
using Workshop.Entities;
using Workshop.Interfaces;
using Workshop.Services.Base;
using Workshop.Utils;
using Workshop.Interfaces.Services;

namespace Workshop.Services
{
    public class RequestService : ServiceBase<Request>, IRequestService
    {
        public RequestService(CarContext context) : base(context) { }

        public async Task<IEnumerable<Request>> GetAllRequests()
        {
            return await Context.Set<Request>()
                        .GetAllNotHidden()
                        .Include(e => e.Car)
                        .ThenInclude(c => c.Client)
                        .Include(e => e.Activities)
                        .ThenInclude(e => e.Worker)
                        .Include(e => e.Manager)
                        .ToListAsync();
        }

        public async Task<Request> GetRequest(Guid id)
        {
            return await Context.Set<Request>()
                        .GetAllNotHidden()
                        .Include(e => e.Car)
                        .ThenInclude(c => c.Client)
                        .Include(e => e.Activities)
                        .ThenInclude(e => e.ActivityType)
                        .Include(e => e.Activities)
                        .ThenInclude(e => e.Worker)
                        .Include(e => e.Manager)
                        .Where(e => e.Id == id)
                        .FirstOrDefaultAsync();
        }

        public Request GetRequestSync(Guid id)
        {
            return Context
                .Set<Request>()
                .GetAllNotHidden()
                .Where(a => a.Id == id)
                .FirstOrDefault();
        }
    }
}
