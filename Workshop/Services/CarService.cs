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
        private readonly ICarRepository carRepository;

        public CarService(CarContext context, ICarRepository carRepository)
        {
            this.carRepository = carRepository;
        }

        public async Task AddCar(Car car)
        {
            await carRepository.CreateAsync(car);
            await carRepository.SaveChangesAsync();
        }

        public async Task EditCar(Car car)
        {
            carRepository.Update(car);
            await carRepository.SaveChangesAsync();
        }

        public async Task<Car> GetCar(Guid Id)
        {
            return await carRepository.GetCar(Id);
        }

        public async Task<IEnumerable<Car>> GetAllCars() => await carRepository.GetAllAsync();

        public async Task<IEnumerable<Car>> GetAllCarsWithClients() => await carRepository.GetAllWithClientsAsync();
    }
}
