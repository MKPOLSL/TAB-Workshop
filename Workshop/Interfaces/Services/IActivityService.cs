using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop.Entities;

namespace Workshop.Interfaces
{
    interface IActivityService
    {
        IEnumerable<Activity> GetAllActivities();
        Task AddActivity();
    }
}
