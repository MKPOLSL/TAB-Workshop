using Blazored.LocalStorage;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Workshop.DataAccess;
using Workshop.Dtos;
using Workshop.Entities;
using Workshop.Interfaces;

namespace Workshop.Services
{
    public class UserAuthorizationService : IUserAuthorizationService
    {
        private readonly CarContext context;
        private readonly ILocalStorageService localStorageService;

        public UserAuthorizationService(CarContext context, ILocalStorageService localStorageService)
        {
            this.context = context;
            this.localStorageService = localStorageService;
        }

        public async Task<Employee> LoginUser(UserLoginDto employee)
        {
            var user = context.Employee
                .Where(u => u.Username == employee.Username && u.Password == employee.Password)
                .FirstOrDefault();

            if (user != null)
            {
                await localStorageService.SetItemAsync("User", new UserStorageDto() 
                { 
                    Username = user.Username,
                    Role = user.Role
                });
                return user;
            }
            else return null;
        }
    }
}
