using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class ItensEntrada
    {
        public int id { get; set; }
        public int idSaidaProduto { get; set; }
        public int idProduto { get; set; }
        public int quantidade { get; set; }
        public double valorUnitario { get; set; }
        public int idFornecedor { get; set; }

        public ItensEntrada(int IDProduto, int idFornecedor, int Quantidade, double ValorUnitario)
        {
            this.idProduto = IDProduto; 
            this.quantidade = Quantidade;
            this.valorUnitario = ValorUnitario;
            this.idFornecedor = idFornecedor;
        }

        public ItensEntrada()
        {
        }
    }
}
