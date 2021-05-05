﻿using System;
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
        Task AddCar();
        Task AddCar(Car car);
    }
}
