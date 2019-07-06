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
        public double valorTotal { get; set; }
        public DateTime dataSaida { get; set; }
        public List<ItensSaida> itens = new List<ItensSaida>();


        public SaidaProdutos(int idUsuario, DateTime dataSaida)
        {
            this.idUsuarioVendedor = idUsuario;
            this.dataSaida = dataSaida;
            this.itens = new List<ItensSaida>();
        }
        public SaidaProdutos()
        {

        }
    }
    
    

}
