using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class ItensSaida
    {
        public int idProduto { get; set; }
        public double valorUnitario { get; set; }
        public int idSaidaProduto { get; set; }
        public int quantidade { get; set; }
        public int id { get; set; }


        public ItensSaida(int IDProduto, int Quantidade, double ValorUnitario)
        {
            this.idProduto = IDProduto;
            this.quantidade = Quantidade;
            this.valorUnitario = ValorUnitario;
        }

        public ItensSaida()
        {
        }
    }
}
