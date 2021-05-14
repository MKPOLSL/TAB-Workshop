using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop.Entities;
using Workshop.Interfaces.Services.Base;

namespace Workshop.Interfaces
{
    interface IActivityTypeService : IServiceBase<ActivityType>
    {
        Task<ActivityType> GetActivityTypeByCode(string code);
    }
}
