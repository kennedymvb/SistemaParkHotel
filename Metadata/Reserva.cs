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
        public int idUsuario { get; set; }
        public DateTime dataPrevisaoChegada { get; set; }
        public DateTime dataPrevisaoSaida { get; set; }
        public int idQuarto { get; set; }

        public Reserva(int ID, int IDCliente, int IDUsuario, DateTime DataPrevChegada, DateTime DataPrevSaida, int IDQuarto)
        {

            this.id = ID;
            this.idCliente = IDCliente;
            this.idUsuario = IDUsuario;
            this.dataPrevisaoChegada = DataPrevChegada;
            this.dataPrevisaoSaida = DataPrevSaida;
            this.idQuarto = IDQuarto;


        }





    }
}
