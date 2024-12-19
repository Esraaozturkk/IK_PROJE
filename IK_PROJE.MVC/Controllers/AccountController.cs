using AspNetCoreHero.ToastNotification.Abstractions;
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
    public class AccountController(IManager<User> userManager, INotyfService notyfService) : Controller
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
            if (user.RoleId == 1)
            {
                return RedirectToAction("Hizmetler", "Sayfa");
            }
            //else if (user.RoleId == 2)
            //{
            //    return RedirectToAction("Index", "Home");
            //}
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier,loginVM.Email)
            };

            //if (user != null)
            //{
            //    claims.Add(new Claim("userId", user.Id.ToString()));  // userId'yi claim olarak ekliyoruz
            //}

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var authenticationProperty = new AuthenticationProperties()
            {
                IsPersistent = loginVM.RememberMe
            };

            var userPrincipal = new ClaimsPrincipal(claimsIdentity);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                userPrincipal, authenticationProperty);

            return RedirectToAction("Index", "Home"); 
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");

        }
    }
}
