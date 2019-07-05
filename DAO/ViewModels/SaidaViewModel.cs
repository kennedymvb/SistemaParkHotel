using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.ViewModels
{
    public class SaidaViewModel
    {
        public int Lote { get; set; }
        public DateTime Data_Entrada { get; set; }
        public DateTime Data_Saida { get; set; }
        public string Produto { get; set; }
        public string Cliente { get; set; }
        public string Valor_Unitario { get; set; }
        public int Quantidade { get; set; }
        public string Valor_Lote { get; set; }  

        public SaidaViewModel(int lote, string produto, string valorLote, string valorUnitario, string cliente,
                                        int quantidade, DateTime dataEntrada, DateTime dataSaida)
        {
            this.Lote = lote;
            this.Produto = produto;
            this.Valor_Lote = valorLote;
            this.Cliente = cliente;
            this.Quantidade = quantidade;
            this.Data_Entrada = dataEntrada;
            this.Data_Saida = dataSaida;
            this.Valor_Unitario = valorUnitario;
        }
        public SaidaViewModel()
        {

        }
    }
}
