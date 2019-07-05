using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class EntradaProdutos
    {
        public int id { get; set; }
        public int usuarioId { get; set; }
        public DateTime dataEntrada { get; set; }
        public double valorTotal { get; set; }
        public List<ItensEntrada> itens { get; set; }

        public EntradaProdutos(int IDusuario, DateTime Dataentrada, double valorTotal)
        {
            this.usuarioId = IDusuario;
            this.dataEntrada = Dataentrada;
            this.valorTotal = valorTotal;
            this.itens = new List<ItensEntrada>();
        }
        public EntradaProdutos()
        {

        }




    }
}
