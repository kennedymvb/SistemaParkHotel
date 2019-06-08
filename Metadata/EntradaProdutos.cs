using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class EntradaProdutos
    {
        
        public int usuarioId { get; set; }
        public DateTime dataEntrada { get; set; }
        public double valorTotal { get; set; }

        public EntradaProdutos(int IDusuario, DateTime Dataentrada, double Valortotal)
        {
            this.usuarioId = IDusuario;
            this.dataEntrada = Dataentrada;
            this.valorTotal = Valortotal;
        }




    }
}
