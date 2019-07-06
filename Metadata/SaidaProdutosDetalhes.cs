using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class SaidaProdutosDetalhes
    {
        public int id { get; set; }
        public int idCheckin { get; set; }
        public int idSaidaProduto { get; set; }
        public int idProduto { get; set; }
        public int Quantidade { get; set; }
        public double Valorunitario { get; set; }
        public int idEntradaProdutos { get; set; }

        public SaidaProdutosDetalhes(int id, int IDCliente, int IDSaidaProduto, int IDProduto, int quantidade, double ValorUnitario)
        {
            this.idCheckin = IDCliente;
            this.idSaidaProduto = IDSaidaProduto;
            this.idProduto = IDProduto;
            this.Quantidade = quantidade;
            this.Valorunitario = ValorUnitario;
            this.idEntradaProdutos = idEntradaProdutos;
        }

        public SaidaProdutosDetalhes()
        {

        }

    }
}
