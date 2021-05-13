using Blazored.LocalStorage;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop.DataAccess;
using Workshop.Dtos;
using Workshop.Entities;
using Workshop.Enums;
using Workshop.Interfaces;
using Workshop.Services.Base;
using Workshop.Utils;

namespace Workshop.Services
{
    public class EmployeeService : ServiceBase<Employee>, IEmployeeService
    {
        private readonly ILocalStorageService localStorageService;

        public EmployeeService(CarContext context, ILocalStorageService localStorageService) : base(context) 
        {
            this.localStorageService = localStorageService;
        }

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

        public async Task<Employee> GetByUsername(string username)
        {
            return await Context
                .Set<Employee>()
                .GetAllNotHidden()
                .Where(e => e.Username.Equals(username))
                .FirstOrDefaultAsync();
        }

        public async Task<Employee> GetUserFromLocalStorage()
        {
            UserStorageDto employee = await localStorageService.GetItemAsync<UserStorageDto>("User");

            return await GetByUsername(employee.Username);
        }
    }
}
