using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop.Entities;
using Workshop.Interfaces.Services.Base;

namespace Workshop.Interfaces
{
    public interface ICarService : IServiceBase<Car>
    {
        Task<IEnumerable<Car>> GetAllCarsWithClients();
        Task<Car> GetCar(Guid id);
        Task<Car> GetCarByRegistrationNumber(string registrationNumber);
    }
}
