﻿using AspNetCoreHero.ToastNotification.Abstractions;
using IK_PROJE.Business.Managers.Abstract;
using IK_PROJE.Entity.Entities.Concrete;
using IK_PROJE.MVC.Models.VMs;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace IK_PROJE.MVC.Controllers
{
    public class AccountController(IManager<MyUser> userManager, INotyfService notyfService, IManager<Role> roleManager) : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            LoginVM loginVM = new LoginVM();
            return View(loginVM);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            var user = userManager.GetAllInclude(p => p.Email == loginVM.Email && p.Password == loginVM.Password).FirstOrDefault();

            if (user == null)
            {
                notyfService.Error("Email veya Şifre Hatalı");
                return View();
            }

            int roleid = user.RoleId;
            string role= roleManager.GetById(roleid).RoleName;
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier,loginVM.Email),
                new Claim(ClaimTypes.Role,role)
            };

            if (user != null)
            {
                claims.Add(new Claim("userId", user.Id.ToString()));  // userId'yi claim olarak ekliyoruz
            }

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var authenticationProperty = new AuthenticationProperties()
            {
                IsPersistent = loginVM.RememberMe
            };

            var userPrincipal = new ClaimsPrincipal(claimsIdentity);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                userPrincipal, authenticationProperty);
            if (user.RoleId == 1)
            {
                return RedirectToAction("Create", "Jobs");
            }

            return RedirectToAction("Index", "Home"); 
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");

        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            RegistrationVM kayitVM = new RegistrationVM();
            return View(kayitVM);
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Register(RegistrationVM registrationVM)
        {
            if (!ModelState.IsValid)
            {
                notyfService.Error("Düzeltilmesi gereken yerler var");
                return View(registrationVM);
            }

            MyUser user = new MyUser();
            user.Name = registrationVM.Name;
            user.Email = registrationVM.Email;
            user.Password = registrationVM.Password;
            user.Surname= registrationVM.SurName;   
            user.TelNo = registrationVM.TelNo;

            userManager.Create(user);

            notyfService.Success("İşlem Başarılı");

            return RedirectToAction("Login", "Account");
        }
    }
}
