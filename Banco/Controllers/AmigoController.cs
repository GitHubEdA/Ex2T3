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
    public class AmigoController : Controller
    {
        private AppPruebaContext context;
        public AmigoController()
        {
            context = new AppPruebaContext();
        }
        public IActionResult Index()
        {
            var userLogged = HttpContext.Session.Get<User>("SessionLoggedUser");
            var amigos = context.Amigos.Include(o => o.User).Where(o => o.IdUserA == userLogged.IdUsuario).ToList();

            return View(amigos);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var userLogged = HttpContext.Session.Get<User>("SessionLoggedUser");
            var usuarios = context.Users.Where(o => o.IdUsuario != userLogged.IdUsuario).ToList();

            return View(usuarios);
        }

        [HttpGet]
        public IActionResult Solicitud(int IdUsuario)
        {
            var userLogged = HttpContext.Session.Get<User>("SessionLoggedUser");
            Solicitud solicitud = new Solicitud();
            solicitud.IdUser = userLogged.IdUsuario;
            solicitud.Estado = "Pendiente";
            solicitud.IdUserEnviado = IdUsuario;

            context.Solicitudes.Add(solicitud);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
