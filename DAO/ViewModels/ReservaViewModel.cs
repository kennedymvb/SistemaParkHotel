using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.ReservaViewModel
{
    public class ReservaViewModel
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public int Quarto { get; set; }
        public string Tipo { get; set; }
        public string valor { get; set; }
        public DateTime DataEntrada  { get; set; }
        public DateTime DataPrevistaSaida { get; set; }
        public int IdFuncionario { get; set; }

        public ReservaViewModel(int Id, string cliente, int quarto, string tipo,
                                string valor, DateTime dataEntrada,
                                 DateTime dataPrevistaSAida, int idFuncionario)
        {
            this.Cliente = cliente;
            this.DataEntrada = dataEntrada;
            this.DataPrevistaSaida = dataPrevistaSAida;
            this.Id = Id;
            this.Quarto = quarto;
            this.valor = valor;
            this.Tipo = tipo;
            this.IdFuncionario = IdFuncionario;
        }
        public ReservaViewModel()
        {

        }

    }
}
