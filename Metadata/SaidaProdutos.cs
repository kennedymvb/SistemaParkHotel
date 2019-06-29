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
        public DateTime dataSaida { get; set; }


        public SaidaProdutos(int idUsuario,  int idCliente, int idProduto, DateTime dataSaida)
        {
            this.idUsuarioVendedor = idUsuario;
            this.idProduto = idProduto;
            this.idCliente = idCliente;
            this.dataSaida = dataSaida;
        }
        public SaidaProdutos()
        {

        }
    }
    
    

}
