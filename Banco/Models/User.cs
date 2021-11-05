using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class User
    {
        public int IdUsuario { set; get; }
        [Required]
        public string Usuario { set; get; }
        [Required]
        public string Username { set; get; }
        [Required]
        public string Password { set; get; }
        public int SaldoTotal { set; get; }
        public List<Amigo> Amigos { set; get; }
        public List<Solicitud> Solicitudes { get; set; }
    }
}
