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


namespace Workshop.Services
{
    public class ActivityService : ServiceBase<Activity>, IActivityService
    {
        public ActivityService(CarContext context) : base(context) { }

        public async Task<Activity> GetActivity(Guid id)
        {
            return await Context
                .Set<Activity>()
                .GetAllNotHidden()
                .Include(a => a.Worker)
                .Include(a => a.ActivityType)
                .Include(a => a.Request)
                .Where(a => a.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Activity>> GetWorkerActivities(Guid workerId)
        {
            return await Context
                .Set<Activity>()
                .GetAllNotHidden()
                .Include(a => a.Worker)
                .Include(a => a.ActivityType)
                .Include(a => a.Request)
                .Where(a => a.Worker.Id == workerId)
                .ToListAsync();
        }
    }
}
