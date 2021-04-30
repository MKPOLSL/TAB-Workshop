using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop.Dtos;

namespace Workshop.Interfaces
{
    interface IUserAuthorizationService
    {
        Task<bool> LoginUser(UserLoginDto employee);
    }
}
