using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.DB;
using WebApplication3.Extensiones;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    [Authorize]
    public class CuentaController : Controller
    {
        private AppPruebaContext context;
        public CuentaController()
        {
            context = new AppPruebaContext();
        }
        public IActionResult Index()
        {
            var userLogged = HttpContext.Session.Get<User>("SessionLoggedUser");
            var cuenta = context.Cuentas.Where(o => o.IdUsuario == userLogged.IdUsuario).ToList();

            return View(cuenta);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categoria = GetCategorias();
            return View(new Cuenta());
        }
        [HttpPost]
        public IActionResult Create(Cuenta cuenta)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Categoria = GetCategorias();
                return View(cuenta);
            }

            var userLogged = HttpContext.Session.Get<User>("SessionLoggedUser");
            cuenta.IdUsuario = userLogged.IdUsuario;
            cuenta.LimiteCuenta = cuenta.SaldoInicial;

            context.Cuentas.Add(cuenta);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        private List<String> GetCategorias()
        {
            return new List<string>
            {
                "Propia","Credito"
            };
        }
    }
}
