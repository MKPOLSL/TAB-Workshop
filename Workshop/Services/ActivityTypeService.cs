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
    public class ActivityTypeService : ServiceBase<ActivityType>, IActivityTypeService
    {
        public ActivityTypeService(CarContext context) : base(context) { }

        public async Task<ActivityType> GetActivityTypeByCode(string code)
        {
            return await Context
                .Set<ActivityType>()
                .GetAllNotHidden()
                .Where(a => a.Code == code)
                .FirstOrDefaultAsync();
        }
    }
}
