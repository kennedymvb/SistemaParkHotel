using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class EntradaProdutos
    {
        public  int id{ get; set; }
        public int usuarioId { get; set; }
        public DateTime dataEntrada { get; set; }
        public double valorTotal { get; set; }

        public EntradaProdutos(int IDusuario, DateTime Dataentrada)
        {
            this.usuarioId = IDusuario;
            this.dataEntrada = Dataentrada;
        }
        public EntradaProdutos()
        {

        }




    }
}
