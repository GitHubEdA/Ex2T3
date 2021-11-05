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
    public class TransferenciaController : Controller
    {
        private AppPruebaContext context;
        public TransferenciaController()
        {
            context = new AppPruebaContext();
        }
        public IActionResult Index()
        {

            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            var userLogged = HttpContext.Session.Get<User>("SessionLoggedUser");
            var cuentas = context.Cuentas
                .Where(o => o.IdUsuario == userLogged.IdUsuario)
                .Where(o => o.Categoria == "Propia")
                .ToList();
            return View(cuentas);
        }
        [HttpPost]
        public IActionResult Create(Transferencia transferencia)
        {
            var userLogged = HttpContext.Session.Get<User>("SessionLoggedUser");
            transferencia.IdUsuario = userLogged.IdUsuario;
            CambiosTransferencia(transferencia);
            context.Transferencias.Add(transferencia);
            context.SaveChanges();
            return RedirectToAction("Index","Cuenta");
        }

        private void CambiosTransferencia(Transferencia transferencia)
        {
            var cuentaInicial = context.Cuentas.Where(o => o.Nombre == transferencia.CuentaInicio).FirstOrDefault();
            var cuentaFinal = context.Cuentas.Where(o => o.Nombre == transferencia.CuentaFinal).FirstOrDefault();

            cuentaInicial.SaldoInicial -= transferencia.Monto;
            cuentaFinal.SaldoInicial += transferencia.Monto;

            context.Entry(cuentaInicial).State = EntityState.Modified;
            context.Entry(cuentaFinal).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
