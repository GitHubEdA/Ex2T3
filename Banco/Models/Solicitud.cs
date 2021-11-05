using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Solicitud
    {
        public int IdSolicitud { get; set; }
        public int IdUser { get; set; }
        public int IdUserEnviado { get; set; }
        public String Estado { get; set; }
        public User User { get; set; }
    }
}
