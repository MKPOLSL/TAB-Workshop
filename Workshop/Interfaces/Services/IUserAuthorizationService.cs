using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop.Dtos;
using Workshop.Entities;

namespace Workshop.Interfaces
{
    interface IUserAuthorizationService
    {
        Task<Employee> LoginUser(UserLoginDto employee);
    }
}
