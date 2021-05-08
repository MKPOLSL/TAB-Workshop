using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop.DataAccess;
using Workshop.Entities;
using Workshop.Interfaces.Repositories;
using Workshop.Repositories.Base;
using Workshop.Utils;

namespace Workshop.Repositories
{
    public class CarRepository : RepositoryBase<Car>, ICarRepository
    {
        public CarRepository(CarContext context) : base(context) { }

        public async Task<IEnumerable<Car>> GetAllWithClientsAsync()
        {
            return await Context
                  .Set<Car>()
                  .GetAllNotHidden()
                  .Include(c => c.Client)
                  .ToListAsync();
        }

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
    }
}