using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.DB;
using WebApplication3.Extensiones;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class InterbancariaController : Controller
    {
        private AppPruebaContext context;
        public InterbancariaController()
        {
            context = new AppPruebaContext();
        }

        [HttpGet]
        public IActionResult Create(int IdUsuario)
        {
            var userLogged = HttpContext.Session.Get<User>("SessionLoggedUser");

            var cuentas = context.Cuentas.Where(o => o.IdUsuario == userLogged.IdUsuario).ToList();
            ViewBag.Interbancarias = context.Cuentas.Where(o => o.IdUsuario == IdUsuario).ToList();

            return View(cuentas);
        }
        [HttpPost]
        public IActionResult Create(Interbancaria interbancaria)
        {
            CambiosTransferencia(interbancaria);
            context.Interbancarias.Add(interbancaria);
            context.SaveChanges();
            return RedirectToAction("Index", "Amigo");
        }

        private void CambiosTransferencia(Interbancaria interbancaria)
        {
            var cuentaInicial = context.Cuentas.Where(o => o.IdCuenta == interbancaria.IdCuentaInicio).FirstOrDefault();
            var cuentaFinal = context.Cuentas.Where(o => o.IdCuenta == interbancaria.IdCuentaFin).FirstOrDefault();

            cuentaInicial.SaldoInicial -= interbancaria.Monto;
            cuentaFinal.SaldoInicial += interbancaria.Monto;

            context.Entry(cuentaInicial).State = EntityState.Modified;
            context.Entry(cuentaFinal).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
