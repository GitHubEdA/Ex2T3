using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Interbancaria
    {
        public int IdInterbancaria { get; set; }
        public int IdCuentaInicio { get; set; }
        public int IdCuentaFin { get; set; }
        public int Monto { get; set; }
        public Cuenta Cuenta { get; set; }

    }
}
