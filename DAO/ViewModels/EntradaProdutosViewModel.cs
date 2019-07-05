using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.ViewModels
{
    public class EntradaProdutosViewModel
    {
        public int Lote { get; set; }
        public DateTime Data { get; set; }
        public string Produto { get; set; }
        public string Fornecedor { get; set; }
        public string Valor_Unitario { get; set; }
        public int Quantidade { get; set; }
        public string Valor_Lote { get; set; }

        public EntradaProdutosViewModel(int lote, string produto, string valorLote, string valorUnitario, string fornecedor,
                                        int quantidade, DateTime data)
        {
            this.Lote = lote;
            this.Produto = produto;
            this.Valor_Lote = valorLote;
            this.Fornecedor = fornecedor;
            this.Quantidade = quantidade;
            this.Data = data;
            this.Valor_Unitario = valorUnitario;
        }
        public EntradaProdutosViewModel()
        {

        }
    }
    

}
