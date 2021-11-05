using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication3.DB;
using WebApplication3.Extensiones;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class UsuarioController : Controller
    {
        private AppPruebaContext context;
        public UsuarioController()
        {
            context = new AppPruebaContext();
        }
        [HttpGet]
        public IActionResult Index()
        {
            var userLogged = HttpContext.Session.Get<User>("SessionLoggedUser");
            ViewBag.Usuario = context.Users.Where(o => o.IdUsuario == userLogged.IdUsuario).FirstOrDefault();
            return View();
        }
        [HttpGet]
        public IActionResult Saldo()
        {
            var userLogged = HttpContext.Session.Get<User>("SessionLoggedUser");
            var cuenta = context.Cuentas.Where(o => o.IdUsuario == userLogged.IdUsuario).ToList();
            var usuario = context.Users.Where(o => o.IdUsuario == userLogged.IdUsuario).FirstOrDefault();
            usuario.SaldoTotal = 0;

            foreach (var item in cuenta)
            {
                if (item.Categoria == "Propia")
                {
                    usuario.SaldoTotal += item.SaldoInicial;
                }
                if (item.Categoria == "Credito")
                {
                    var n = item.LimiteCuenta - item.SaldoInicial;
                    usuario.SaldoTotal -= n;
                }
            }
            
            context.Entry(usuario).State = EntityState.Modified;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
