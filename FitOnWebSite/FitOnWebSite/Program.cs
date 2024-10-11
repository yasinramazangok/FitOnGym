using BusinessLayer.Containers;
using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Authentication.Cookies; // for CookieAuthenticationDefaults
using Microsoft.AspNetCore.Authorization; // for AuthorizationPolicyBuilder
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization; // for AuthorizeFilter
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace FitOnWebSite
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetConnectionString("ContextConnection") ?? throw new InvalidOperationException("Veritabanýna baðlanýlamadý!");

            builder.Services.AddDbContext<Context>(); // for database

            builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<Context>();

            //builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<Context>();

            builder.Services.ContainerDependencies();

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //builder.Services.AddSwaggerGen();

            builder.Services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .Build();
                config.Filters.Add(new AuthorizeFilter(policy));
            });

            builder.Services.AddAuthentication(
                CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = "/Login/Index/";
                    options.Cookie.Name = "FitOnAuthCookie"; 
                    options.Cookie.HttpOnly = true; 
                });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error/");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //app.UseSwagger();
            //app.UseSwaggerUI(s =>
            //{
            //    s.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            //    // s.RoutePrefix = string.Empty; 
            //});

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
         
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Default}/{action=Index}/{id?}"
            );

            app.Run();
        }
    }
}