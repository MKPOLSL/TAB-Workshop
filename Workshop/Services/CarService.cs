using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop.DataAccess;
using Workshop.Entities;
using Workshop.Interfaces;
using Workshop.Interfaces.Repositories;

namespace Workshop.Services
{
    public class CarService : ICarService
    {
        private readonly CarContext context;
        private readonly ICarRepository carRepository;

        public CarService(CarContext context, ICarRepository carRepository)
        {
            this.context = context;
            this.carRepository = carRepository;
        }

        public async Task AddCar()
        {
            var car = new List<Car>
            {
                new Car{
                Id = Guid.NewGuid(),
                Brand = "Lancia",
                Model = "Lybra",
                ProductionYear = 2000
                },
                new Car{
                Id = Guid.NewGuid(),
                Brand = "Audi",
                Model = "A4",
                ProductionYear = 2008
                },
                new Car{
                Id = Guid.NewGuid(),
                Brand = "Fiat",
                Model = "124p",
                ProductionYear = 1981
                },
            };
            context.Set<Car>().AddRange(car);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Car>> GetAllCars() => await carRepository.GetAllAsync();

        public async Task<IEnumerable<Car>> GetAllCarsWithClients() => await carRepository.GetAllWithClientsAsync();
    }
}
