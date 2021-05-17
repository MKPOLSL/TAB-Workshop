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
    public class CarService : ServiceBase<Car>, ICarService
    {
        public CarService(CarContext context) : base(context) { }

        public async Task<Car> GetCar(Guid id)
        {
            return await Context
                  .Set<Car>()
                  .GetAllNotHidden()
                  .Include(c => c.Client)
                  .Include(c => c.CarType)
                  .Where(c => c.Id == id)
                  .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Car>> GetAllCarsWithClients()
        {
            return await Context
                  .Set<Car>()
                  .Include(c => c.Client)
                  .ToListAsync();
        }

        public async Task<Car> GetCarByRegistrationNumber(string registrationNumber)
        {
            return await Context
                  .Set<Car>()
                  .GetAllNotHidden()
                  .Include(c => c.Client)
                  .Include(c => c.CarType)
                  .Where(c => c.RegistrationNumber == registrationNumber)
                  .FirstOrDefaultAsync();
        }
    }
}
