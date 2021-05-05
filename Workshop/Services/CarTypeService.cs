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
    public class CarTypeService : ICarTypeService
    {
        private readonly CarContext context;
        private readonly ICarTypeRepository carTypeRepository;

        public CarTypeService(CarContext context, ICarTypeRepository carTypeRepository)
        {
            this.context = context;
            this.carTypeRepository = carTypeRepository;
        }

        public async Task<IEnumerable<CarType>> GetAllTypes()
        {
            return await carTypeRepository.GetAllAsync();
        }
    }
}
