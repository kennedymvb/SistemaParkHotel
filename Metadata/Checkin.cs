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
        public int idUsuario { get; set; }
        

        public Checkin(int idUsuario, DateTime dataentrada, DateTime dataprevistasaida, int idquarto, int idcliente, int idreserva)
        {
            this.idUsuario = idUsuario;
            this.dataEntrada = dataentrada;
            this.dataPrevistaSaida = dataprevistasaida;
            this.quartoId = idquarto;
            this.clienteId = idcliente;
            this.idReserva = idreserva;

        }

        public Checkin(int idUsuario, DateTime dataentrada, DateTime dataprevistasaida, int idquarto, int idcliente)
        {
            this.idUsuario = idUsuario;
            this.dataEntrada = dataentrada;
            this.dataPrevistaSaida = dataprevistasaida;
            this.quartoId = idquarto;
            this.clienteId = idcliente;
            

        }
        public Checkin()
        {

        }
    }
}
