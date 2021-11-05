using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Transferencia
    {
        public int IdTransferencia { set; get; }
        public string CuentaInicio { set; get; }
        public string CuentaFinal { set; get; }
        public int Monto { set; get; }
        public int IdUsuario { set; get; }
    }
}
