using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Checkin
    {
        public int id { get; set; }
        public DateTime dataEntrada { get; set; }
        public DateTime dataPrevistaSaida { get; set; }
        public int quartoId { get; set; }
        public int clienteId { get; set; }
        public int idReserva { get; set; }


    }
}
