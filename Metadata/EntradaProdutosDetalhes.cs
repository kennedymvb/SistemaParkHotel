using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class EntradaProdutosDetalhes
    {
        public int id { get; set; }
        public int idEntradaProduto { get; set; }
        public int idProduto { get; set; }
        public int idFornecedor { get; set; }
        public int quantidade { get; set; }
        public double valorUnitario { get; set; }

        public EntradaProdutosDetalhes(int id, int IDentradaproduto, int IDProduto, int IDFornecedor, int Quantidade, double ValorUnitario)
        {
            this.id = id;
            this.idEntradaProduto = IDentradaproduto;
            this.idProduto = IDProduto;
            this.idFornecedor = IDFornecedor;
            this.quantidade = Quantidade;
            this.valorUnitario = ValorUnitario;

        }

        public EntradaProdutosDetalhes()
        {
        }
    }
}
