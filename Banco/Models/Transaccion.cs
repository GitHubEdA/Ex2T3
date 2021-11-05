using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Transaccion
    {
        public int IdTransaccion { set; get; }
        public int IdCuenta { set; get; }
        public string Fecha { set; get; }
        public string Descripcion { set; get; }
        public int Monto { set; get; }
        public bool Tipo { set; get; }
        public Cuenta Cuenta { set; get; }
    }
}
