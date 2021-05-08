using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop.Entities;

namespace Workshop.Interfaces
{
    public interface ICarService
    {
        Task<IEnumerable<Car>> GetAllCars();
        Task<IEnumerable<Car>> GetAllCarsWithClients();
        Task AddCar(Car car);
        Task EditCar(Car car);
        Task<Car> GetCar(Guid id);
    }
}
