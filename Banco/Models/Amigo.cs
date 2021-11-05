using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Amigo
    {
        public int IdAmigo { set; get; }
        public int IdUser { set; get; }
        public int IdUserA { set; get; }
        public User User { set; get; }
    }
}
