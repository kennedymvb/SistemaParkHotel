using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class SaidaProdutos
    {
        public int idUsuarioVendedor { get; set; }
        public int id { get; set; }
        public int idCliente { get; set; }
        public int idProduto { get; set; }
        public double valorTotal { get; set; }


        public SaidaProdutos(int idUsuario, int qtd, int idCliente, int idProduto)
        {
            this.idUsuarioVendedor = idUsuario;
            this.idProduto = idProduto;
            this.idCliente = idCliente;
        }
        public SaidaProdutos()
        {

        }
    }
    
    

}
