using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metadata;
using DAL;

namespace BLL
{
    class SaidaProdutosDetalhesBLL
    {
        List<string> erros = new List<string>();
        ProdutoDAL produtoDAL = new ProdutoDAL();
        SaidaProdutosDAL saidaProdutosDal = new SaidaProdutosDAL();
        UsuarioDAL usuarioDAL = new UsuarioDAL();
        ClienteDAL clienteDAL = new ClienteDAL();
        EntradaProdutosDAL entradaProdutosDAL = new EntradaProdutosDAL();


        SaidaProdutosDetalhesDAL saidaDal = new SaidaProdutosDetalhesDAL();

        public string inserir(SaidaProdutosDetalhes saida)
        {
            if (this.Validar(saida))
            {
               return saidaDal.Inserir(saida);
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < erros.Count(); i++)
            {
                sb.Append(erros[i]);
            }
            return sb.ToString();
        }

        public string atualizar(SaidaProdutosDetalhes saida)
        {
            if (this.Validar(saida))
            {
                return saidaDal.Atualizar(saida);
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < erros.Count(); i++)
            {
                sb.Append(erros[i]);
            }
            return sb.ToString();
        }

        public bool Validar(SaidaProdutosDetalhes saida)
        {
            
            if (saida.Valorunitario < 0)
                erros.Add("o valor tem não pode ser negativo");

            if (saida.Quantidade < 0)
            {
                erros.Add("a  quantidade não pode ser menor que 0");
            }

            if (erros.Count() > 0)
            {
                return false;
            }
            return true;
        }

        public SaidaProdutosDetalhes LerPorID(SaidaProdutosDetalhes saidaProdutosDetalhes)
        {
                return saidaDal.LerPorID(saidaProdutosDetalhes.id);
        }
        public List<SaidaProdutosDetalhes> LerTodos()
        {
            return saidaDal.LerTodos();
        }


        private void TratarDependencias(SaidaProdutosDetalhes saida)
        {
            if (saida.idProduto < 0)
            {
                erros.Add("id do produto deve ser informado");
            }
            else
            {
                Produto produto = produtoDAL.LerPorID(saida.idProduto);
                if (produto == null)
                {
                    erros.Add("produto não encontrado no banco");
                }
            }
            if (saida.idCliente < 0)
            {
                erros.Add("id do produto deve ser informado");
            }
            else
            {
                Cliente cliente = clienteDAL.LerPorID(saida.idCliente);
                if (cliente == null)
                {
                    erros.Add("cliente não encontrado no banco");
                }
            }
            
            SaidaProdutos saidaProdutos= saidaProdutosDal.LerPorID(saida.idSaidaProduto);
            if (saidaProdutos == null)
            {
                erros.Add("erro de integridade: não encontrada relação com saída de produto");
            }

            EntradaProdutos entradaProdutos = entradaProdutosDAL.LerPorID(saida.idEntradaProdutos);
            if (entradaProdutos == null)
            {
                erros.Add("erro de integridade: não encontrada relação com a entrada do produto");
            }
            
        }
    }
}
