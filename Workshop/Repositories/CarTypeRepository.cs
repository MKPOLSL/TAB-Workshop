using Microsoft.EntityFrameworkCore;
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

    public class CarTypeRepository : RepositoryBase<CarType>, ICarTypeRepository
    {
        public CarTypeRepository(CarContext context) : base(context) { }

        public Task<CarType> GetTypeByTypeName(string typeName)
        {
            return Context
                .Set<CarType>()
                .GetAllNotHidden()
                .Where(ct => ct.TypeName == typeName)
                .FirstOrDefaultAsync();
        }

        //public virtual async Task<IEnumerable<CarType>> GetAllAsync()
        //{
        //    return Context
        //        .Set<CarType>()
        //        .GetAllNotHidden()
        //        .ToList();
        //}
    }
}