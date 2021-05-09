using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Workshop.Dtos;
using Workshop.Entities;

namespace Workshop.Services
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly ILocalStorageService localStorageService;

        public CustomAuthenticationStateProvider(ILocalStorageService localStorageService)
        {
            this.localStorageService = localStorageService;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            UserStorageDto employee = await localStorageService.GetItemAsync<UserStorageDto>("User");

            ClaimsIdentity identity;

            if(employee != null)
            {
                identity = new ClaimsIdentity(new[] 
                {
                    new Claim(ClaimTypes.Name, employee.Username),
                    new Claim(ClaimTypes.Role, employee.Role.ToString())
                }, "apiauth_type");
            }
            else
            {
                identity = new ClaimsIdentity();
            }

            var user = new ClaimsPrincipal(identity);
            
            return await Task.FromResult(new AuthenticationState(user));
        }

        public void MarkUserAsAuthenticated(Employee employee)
        {
            var identity = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name, employee.Username),
                new Claim(ClaimTypes.Role, employee.Role.ToString())
            }, "apiauth_type");

            var user = new ClaimsPrincipal(identity);

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }

        public void MarkUserAsLoggedOut()
        {
            localStorageService.RemoveItemAsync("User");

            var identity = new ClaimsIdentity();

            var user = new ClaimsPrincipal(identity);

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }
    }
}
