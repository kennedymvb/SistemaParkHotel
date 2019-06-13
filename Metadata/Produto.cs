using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Produto
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public double preco { get; set; }
        public int usuarioId { get; set; }
        public int qtd_estoque { get; set; }


        public Produto(int ID, string Nome, string Descricao, double Preco, int IDUsuario, int QuantEstoque)
        {
            this.id = ID;
            this.nome = Nome;
            this.descricao = Descricao;
            this.preco = Preco;
            this.usuarioId = IDUsuario;
            this.qtd_estoque = QuantEstoque;

        }

        public Produto()
        {
        }
    }
}
