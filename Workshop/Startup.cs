using Blazored.LocalStorage;
using Blazored.Modal;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Workshop.DataAccess;
using Workshop.Interfaces;
using Workshop.Interfaces.Services;
using Workshop.Services;

namespace Workshop
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddBlazoredLocalStorage();
            services.AddAuthorizationCore();

            services.AddDbContext<CarContext>(options =>
                          options.UseSqlServer(
                              Configuration.GetConnectionString("DefaultConnection"))
                              );
            //services  
            services.AddScoped<ICarService, CarService>();
            services.AddScoped<IClientService, ClientService>();
            services.AddScoped<IUserAuthorizationService, UserAuthorizationService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IActivityService, ActivityService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IRequestService, RequestService>();
            services.AddScoped<ICarTypeService, CarTypeService>();
            services.AddScoped<IRequestService, RequestService>();
            services.AddScoped<IActivityTypeService, ActivityTypeService>();
            services.AddBlazoredModal();

            services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
            //Register dapper in scope  
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
