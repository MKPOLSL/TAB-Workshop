using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

using System.Threading.Tasks;
using Workshop.DataAccess;
using Workshop.Dtos;
using Workshop.Entities;
using Workshop.Interfaces;

namespace Workshop.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly CarContext context;

        public EmployeeService(CarContext context)
        {
            this.context = context;
        }

        public async Task AddEmployee(Employee employee) 
        {
            context.Set<Employee>().Add(employee);
            await context.SaveChangesAsync();
        }

        public IEnumerable<Employee> GetAllUsers()
        => context.Employee.ToList();      
    }
}
