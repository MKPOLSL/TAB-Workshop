using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop.DataAccess;
using Workshop.Entities;
using Workshop.Enums;
using Workshop.Interfaces;
using Workshop.Services.Base;
using Workshop.Utils;

namespace Workshop.Services
{
    public class EmployeeService : ServiceBase<Employee>, IEmployeeService
    {
        public EmployeeService(CarContext context) : base(context) { }

        public async Task<IEnumerable<Employee>> GetAllManagers()
        {
            return await Context
                .Set<Employee>()
                .GetAllNotHidden()
                .Where(e => e.Role == Role.Manager)
                .ToListAsync();
        }

        public async  Task<Employee> GetById(Guid id)
        {
            return await Context
                .Set<Employee>()
                .GetAllNotHidden()
                .Where(e => e.Id == id)
                .FirstOrDefaultAsync();
        }
    }
}
