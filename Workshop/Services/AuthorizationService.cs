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
    public class AuthorizationService : IAuthorizationService
    {
        private readonly CarContext context;
        private readonly HttpContext httpContext;

        public AuthorizationService(CarContext context, HttpContext httpContext)
        {
            this.context = context;
            this.httpContext = httpContext;
        }
    }
}
