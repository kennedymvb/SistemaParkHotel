using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    class SaidaProdutosDetalhes
    {
        public int idCliente { get; set; }
        public int idSaidaProduto { get; set; }
        public int idProduto { get; set; }
        public int idFornecedor { get; set; }
        public int Quantidade { get; set; }
        public double Valorunitario { get; set; }

        public SaidaProdutosDetalhes(int IDCliente, int IDSaidaProduto, int IDProduto, int IDFornecedor, int quantidade, double ValorUnitario)
        {
            this.idCliente = IDCliente;
            this.idSaidaProduto = IDSaidaProduto;
            this.idProduto = IDProduto;
            this.idFornecedor = IDFornecedor;
            this.Quantidade = quantidade;
            this.Valorunitario = ValorUnitario;

        }



    }
}
