using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class ItensSaida
    {
       
        public int id { get; set; }
        public int idSaidaProduto { get; set; }
        public int idProduto { get; set; }
        public int idCliente { get; set; }
        public int quantidade { get; set; }
        public double valorUnitario { get; set; }

        public ItensSaida(int IDProduto, int idCliente, int Quantidade, double ValorUnitario)
        {
            this.idProduto = IDProduto;
            this.idCliente = idCliente;
            this.quantidade = Quantidade;
            this.valorUnitario = ValorUnitario;
        }

        public ItensSaida()
        {
        }
    }
}
