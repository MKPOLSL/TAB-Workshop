using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop.Entities;
using Workshop.Interfaces.Repositories.Base;

namespace Workshop.Interfaces.Repositories
{
    public interface ICarTypeRepository : IRepositoryBase<CarType>
    {
        Task<CarType> GetTypeByTypeName(string typeName);
    }
}