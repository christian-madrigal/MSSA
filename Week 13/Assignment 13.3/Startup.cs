using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment_13._3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;


namespace Assignment_13._3
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllersWithViews();
            //step 5 
            //restiering services
            //services.AddSingleton<IData, Data>();
            services.AddScoped<IData, DBData>();
            //services.AddDbContext<EmployeeContext>(options => options.UseSqlite("Data Source=Employees.db"));
            services.AddDbContext<ProductContext>(options => options.UseSqlServer("Server=Desktop-TN2F3BI;Database=GloboShoes;Trusted_Connection=True;MultipleActiveResultSets=True"));
            services.AddIdentity<Customer, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 8;

            }).AddEntityFrameworkStores<CustomerContext>();
            services.AddDbContext<CustomerContext>(options => options.UseSqlServer("Server=Desktop-TN2F3BI;Database=Customers;Trusted_Connection=True;MultipleActiveResultSets=True"

                ));



        }
        //public async void CreateRoles(RoleManager<IdentityRole> roleManager)
        //{
        //    string[] rolenames = { "Admin", "Employee" };
        //    foreach (var rolename in rolenames)
        //    {
        //        bool roleExists = await roleManager.RoleExistsAsync(rolename);
        //        if (!roleExists)
        //        {
        //            IdentityRole role = new IdentityRole();
        //            role.Name = rolename;
        //            await roleManager.CreateAsync(role);
        //        }
        //    }
        //}



        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, CustomerContext userContext, RoleManager<IdentityRole> roleManager)
        {
            //employeeContext.Database.EnsureDeleted();
            //employeeContext.Database.EnsureCreated();
            userContext.Database.EnsureCreated();
            //userContext.Dispose();
            // create 2 roles
            //     CreateRoles(roleManager);
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else if (env.IsProduction())
            {
                app.UseExceptionHandler("/Error.html");
            }
            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

