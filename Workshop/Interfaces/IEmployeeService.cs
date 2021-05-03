using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop.Entities;

namespace Workshop.Interfaces
{
    public interface IEmployeeService
    {
        Task AddEmployee(Employee employee);
        Task<IEnumerable<Employee>> GetAllUsers();
    }
}
