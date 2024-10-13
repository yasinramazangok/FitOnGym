using BusinessLayer.Containers;
using DataAccessLayer.Contexts;
using FitOnWebSite.Data;
using FitOnWebSite.Models;
using Microsoft.AspNetCore.Authentication.Cookies; // for CookieAuthenticationDefaults
using Microsoft.AspNetCore.Authorization; // for AuthorizationPolicyBuilder
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization; // for AuthorizeFilter
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using Context = FitOnWebSite.Data.Context;

namespace FitOnWebSite
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var connectionString = builder.Configuration.GetConnectionString("FitOnWebSiteContextConnection");

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<Context>(); // for database

            builder.Services.AddIdentity<AppUser, IdentityRole>
    (
        options =>
        {
            options.Password.RequiredUniqueChars = 0;
            options.Password.RequireUppercase = false;
            options.Password.RequiredLength = 8;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequireLowercase = false;
        }
    )
    .AddEntityFrameworkStores<Context>()
    .AddDefaultTokenProviders();

            builder.Services.ContainerDependencies();

            builder.Services.AddMvc();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error/");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Default}/{action=Index}/{id?}"
            );

            app.Run();
        }
    }
}