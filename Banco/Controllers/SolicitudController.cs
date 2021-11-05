using Microsoft.AspNetCore.Http;
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
    public class SolicitudController : Controller
    {
        private AppPruebaContext context;
        public SolicitudController()
        {
            context = new AppPruebaContext();
        }
        public IActionResult Index()
        {
            var userLogged = HttpContext.Session.Get<User>("SessionLoggedUser");
            var solicitudes = context.Solicitudes.Include(o => o.User).Where(o => o.IdUserEnviado == userLogged.IdUsuario).ToList();

            return View(solicitudes);
        }
        [HttpGet]
        public IActionResult Aceptar(int IdUsuario, int IdSolicitud)
        {
            var userLogged = HttpContext.Session.Get<User>("SessionLoggedUser");

            Amigo amigo = new Amigo();
            Amigo amigo2 = new Amigo();

            amigo.IdUser = userLogged.IdUsuario;
            amigo.IdUserA = IdUsuario;

            amigo2.IdUser = IdUsuario;
            amigo2.IdUserA = userLogged.IdUsuario;

            context.Amigos.Add(amigo);
            context.SaveChanges();

            context.Amigos.Add(amigo2);
            context.SaveChanges();

            var solicitud = context.Solicitudes.Where(o => o.IdSolicitud == IdSolicitud).FirstOrDefault();
            solicitud.Estado = "Aceptada";
            context.Entry(solicitud).State = EntityState.Modified;
            context.SaveChanges();

            return RedirectToAction("Index", "Amigo");
        }
    }
}
