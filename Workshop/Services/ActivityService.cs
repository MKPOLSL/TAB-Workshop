using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop.DataAccess;
using Workshop.Entities;
using Workshop.Interfaces;
using Workshop.Services.Base;

namespace Workshop.Services
{
    public class ActivityService : ServiceBase<Activity>, IActivityService
    {
        public ActivityService(CarContext context) : base(context) { }

        public Task AddActivity()
        {
            throw new NotImplementedException();
        }

        /*public Task AddActivity()
        {
            var activities = new List<Activity>
            {
                new Activity{
                Id = Guid.NewGuid(),
                Description = "Działa",
                Result = "Zrobione",
                Status = 0,
                Registered = DateTime.Now,
                FinishedOrCancelled = DateTime.Now.AddDays(40),
                ActivityType = new ActivityType {
                ActivityName = "",
                Code = "super",
                IsHidden = false
                }
                ,
                Request = new Request
                {
                    Description = "Request test 1",
                    Activities = null,
                    Car = context.Set<Car>().Where(c => c.Brand == "Audi").FirstOrDefault(),
                    FinishedOrCancelled = DateTime.Now.AddDays(4),
                    Id = Guid.NewGuid(),
                    IsHidden = false,
                    Manager = context.Set<Employee>().Where(e => e.Role == 0)
                }

            };
            context.Set<Activity>().AddRange(activities);
            await context.SaveChangesAsync();
            throw new NotImplementedException();
        }
        */
    }
}
