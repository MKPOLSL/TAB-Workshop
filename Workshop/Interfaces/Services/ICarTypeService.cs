using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop.Entities;

namespace Workshop.Interfaces
{
    public interface ICarTypeService
    {
        Task<IEnumerable<CarType>> GetAllTypes();
        Task<CarType> GetTypeByTypeName(string typeName);
    }
}
