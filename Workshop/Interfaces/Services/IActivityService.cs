using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop.Entities;
using Workshop.Interfaces.Services.Base;

namespace Workshop.Interfaces
{
    interface IActivityService : IServiceBase<Activity>
    {
        Task<Activity> GetActivity(Guid id);
        Task<IEnumerable<Activity>> GetWorkerActivities(Guid workerId);
    }
}
