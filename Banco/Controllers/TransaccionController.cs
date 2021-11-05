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
    public class TransaccionController : Controller
    {
        private AppPruebaContext context;
        public TransaccionController()
        {
            context = new AppPruebaContext();
        }

        public IActionResult Index(int IdCuenta)
        {
            var transacciones = context.Transaccions
                .Include(o => o.Cuenta)
                .Where(o => o.IdCuenta == IdCuenta)
                .ToList();
            return View(transacciones);
        }
        [HttpGet]
        public IActionResult Create(int IdCuenta)
        {
            ViewBag.Cuenta = context.Cuentas
                .Where(o => o.IdCuenta == IdCuenta)
                .FirstOrDefault();

            return View(new Transaccion());
        }
        [HttpPost]
        public IActionResult Create(Transaccion transaccion)
        {
            var a = verificarCambios(transaccion);
            if (a == false)
                ModelState.AddModelError("Ingreso", "No se puede gastar lo que no se tiene");

            if (!ModelState.IsValid)
            {
                ViewBag.Cuenta = context.Cuentas
                    .Where(o => o.IdCuenta == transaccion.IdCuenta)
                    .FirstOrDefault();

                return View(transaccion);
            }
            transaccion.Fecha = DateTime.Now.ToString();
            context.Transaccions.Add(transaccion);
            context.SaveChanges();
            
            return RedirectToAction("Index", new { transaccion.IdCuenta});
        }

        private bool verificarCambios(Transaccion transaccion)
        {
            var cuenta = context.Cuentas
                .Where(o => o.IdCuenta == transaccion.IdCuenta)
                .FirstOrDefault();
            bool a = true;

            if (transaccion.Tipo == true) {
                cuenta.SaldoInicial += transaccion.Monto;
            }
            else if (transaccion.Tipo == false)
            {
                if (cuenta.LimiteCuenta < transaccion.Monto)
                {
                    a = false;
                    return a;
                }
                else
                {
                    cuenta.SaldoInicial -= transaccion.Monto;
                }
            }
            
            context.Entry(cuenta).State = EntityState.Modified;
            context.SaveChanges();
            return a;
        }
    }
}
