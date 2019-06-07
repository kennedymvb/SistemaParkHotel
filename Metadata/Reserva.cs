using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Reserva
    {
        public int id { get; set; }
        public int idCliente { get; set; }
        public DateTime data { get; set; }
        public DateTime dataPrevisaoChegada { get; set; }
        public DateTime dataPrevisaoSaida { get; set; }
        public int idQuarto { get; set; }

    }
}
