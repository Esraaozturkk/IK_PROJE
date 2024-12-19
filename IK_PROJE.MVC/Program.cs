
using AspNetCoreHero.ToastNotification;
using AspNetCoreHero.ToastNotification.Extensions;
using IK_PROJE.Business.Managers.Abstract;
using IK_PROJE.DataAccess;
using IK_PROJE.Entity.Entities.Concrete;
using IK_PROJE.MVC.Extensions;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;

namespace IK_PROJE
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDistributedMemoryCache();

            #region DbContext Registiration
            var constr = builder.Configuration.GetConnectionString("InsanKaynaklari");
            builder.Services.AddDbContext<SqlDbContext>(options => options.UseSqlServer(constr));
            #endregion

            #region Notify Service Configuration
            builder.Services.AddNotyf(p =>
            {
                p.Position = NotyfPosition.BottomRight;
                p.DurationInSeconds = 7;
                p.IsDismissable = true;
            });
            #endregion

            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
            {
                options.Cookie.Name = "InsanKaynaklari";
                options.LoginPath = "/Account/Login";
                options.LogoutPath = "/Account/Logout";
                options.AccessDeniedPath = "/Account/ErisimHatasý";
                options.Cookie.HttpOnly = true; //Taray?c?daki di?er scriptler okuyamas?n diye güvenlik 
                options.Cookie.SameSite = SameSiteMode.Strict; //Ba?ka taray?c?lar taraf?ndan ula??lamas?n diye güvenlik önlemi
                options.ExpireTimeSpan = TimeSpan.FromMinutes(10); //
                options.SlidingExpiration = true; //Herhangi sitede bir hareket oldu?unda süreyi 10 dk uzatýr

            });

            builder.Services.AddIKService();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseNotyf();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}