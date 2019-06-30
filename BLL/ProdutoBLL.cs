using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metadata;
using DAL;

namespace BLL
{
    public class ProdutoBLL
    {
        List<string> erros = new List<string>();


        ProdutoDAL ProdutoDal = new ProdutoDAL();

        public string inserir(Produto produto)
        {
            if (this.Validar(produto))
            {
                return ProdutoDal.Inserir(produto);
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < erros.Count(); i++)
            {
                sb.Append(erros[i]);
            }
            return sb.ToString();
        }

        public string Atualizar(Produto produto)
        {
            if (this.Validar(produto))
            {
                return ProdutoDal.Atualizar(produto);
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < erros.Count(); i++)
            {
                sb.Append(erros[i]);
            }
            return sb.ToString();
        }

        public bool Validar(Produto produto)
        {

            if (produto.preco < 0)
            {
                erros.Add("valor inválido");
            }

            if (string.IsNullOrWhiteSpace(produto.nome))
            {
                erros.Add("nome do produto deve ser informado");
            }
            if (string.IsNullOrWhiteSpace(produto.descricao))
            {
                erros.Add("Precisa adicionar descrição do produto");
            }



            if (erros.Count > 0)
            {
                return false;
            }
            return true;
        }

        public Produto LerPorID(int id)
        {

            return ProdutoDal.LerPorID(id);

        }
        public List<Produto> LerTodos()
        {
            return ProdutoDal.LerTodos();
        }
        public void atualizarQuantidadeEstoque(Produto produto)
        {
            ProdutoDal.AtualizarQuantidade(produto);
        }
    }
}
