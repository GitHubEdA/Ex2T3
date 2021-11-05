using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Cuenta
    {
        public int IdCuenta { set; get; }
        [Required]
        public string Nombre { set; get; }
        [Required]
        public string Categoria { set; get; }
        [Required]
        public int SaldoInicial { set; get; }
        [Required]
        public int IdUsuario { set; get; }
        public int LimiteCuenta { set; get; }
    }
}
