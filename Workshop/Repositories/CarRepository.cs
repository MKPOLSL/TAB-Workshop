using Workshop.DataAccess;
using Workshop.Entities;
using Workshop.Interfaces.Repositories;
using Workshop.Repositories.Base;

namespace Workshop.Repositories
{
    public class CarRepository : RepositoryBase<Car>, ICarRepository
    {
        public CarRepository(CarContext context) : base(context) { }
    }
}