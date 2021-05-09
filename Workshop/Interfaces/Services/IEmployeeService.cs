using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop.Entities;
using Workshop.Interfaces.Services.Base;

namespace Workshop.Interfaces
{
    public interface IEmployeeService : IServiceBase<Employee>
    {
        Task<IEnumerable<Employee>> GetAllManagers();
        Task<Employee> GetById(Guid id);
    }
}
