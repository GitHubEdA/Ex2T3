using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebApplication3.DB;
using WebApplication3.Extensiones;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class AuthController : Controller
    {
        private IConfiguration configuration;

        public AuthController(IConfiguration configuration)
        {
            var context = new AppPruebaContext();
            this.configuration = configuration;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            var context = new AppPruebaContext();
            var user = context.Users.FirstOrDefault(o => o.Username == username && o.Password == GetHashedPassword(password));

            if (user == null)
                return View();

            HttpContext.Session.Set("SessionLoggedUser", user);

            var claims = new List<Claim>() {
                new Claim(ClaimTypes.Name, user.Username),
            };

            var userIdentity = new ClaimsIdentity(claims, "login");
            var principal = new ClaimsPrincipal(userIdentity);

            HttpContext.SignInAsync(principal);

            return RedirectToAction("Index", "Cuenta");
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            var context = new AppPruebaContext();
            if (ModelState.IsValid)
            {
                user.SaldoTotal = 0;
                user.Password = GetHashedPassword(user.Password);
                context.Users.Add(user);
                context.SaveChanges();
            }
            return RedirectToAction("Login");
        }

        private string GetHashedPassword(string password)
        {          
            string token = configuration.GetValue<string>("Token");
            password += token;
            var sha = SHA256.Create();
            var hashData = sha.ComputeHash(Encoding.Default.GetBytes(password));
            return Convert.ToBase64String(hashData);
        }

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("Login", "Auth");
        }
    }
}