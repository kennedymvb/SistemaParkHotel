using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Quarto
    {
        public int id { get; set; }
        public double valorDiaria {get; set;}
        public int usuarioId { get; set; }
        public bool estaOcupado { get; set; }
    }
}
