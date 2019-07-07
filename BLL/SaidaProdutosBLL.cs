using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using DAL;
using DAO.ViewModels;
using Metadata;
namespace BLL
{
    public class SaidaProdutosBLL
    {
        List<string> erros = new List<string>();
        SaidaProdutosDAL saidaDal = new SaidaProdutosDAL();
        ClienteBLL clienteBLL = new ClienteBLL();
        UsuarioBLL usuarioBLL = new UsuarioBLL();
        ProdutoBLL produtoBLL = new ProdutoBLL();

        public void inserir(SaidaProdutos saida)
        {
            if (!this.Validar(saida))
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < erros.Count(); i++)
                {
                    sb.Append(erros[i] + "\n");
                }
                throw new Exception(sb.ToString());
            }
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    saida.id = saidaDal.Inserir(saida);
                    saidaDal.InserirItens(saida);
                    foreach (ItensSaida item in saida.itens)
                    {
                        Produto p = produtoBLL.LerPorID(item.idProduto);
                        p.preco = (p.qtdEstoque * p.preco) - (item.quantidade * item.valorUnitario) / (p.qtdEstoque - item.quantidade);
                        p.qtdEstoque -= item.quantidade;
                        produtoBLL.Atualizar(p);
                    }
                    scope.Complete();
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro na transação: " + ex.Message);
                }
            }
           
            
        }

        public bool Validar(SaidaProdutos saida)
        {
            if (saida.valorTotal < 0)
            {
                erros.Add("o valor tem não pode ser negativo");
            }
            TratarDependencias(saida);

            if (erros.Count() > 0)
            {
                return false;
            }
            return true;
        }

        public SaidaProdutos LerPorID(int id)
        {
            return saidaDal.LerPorID(id);

        }
        public List<SaidaViewModel> LerTodos()
        {
            return saidaDal.LerTodos();
        }

        private void TratarDependencias(SaidaProdutos saida)
        {
            if (!(saida.idUsuarioVendedor > 0))
            {
                erros.Add("id do vendedor deve ser informado");
            }
            else
            {
                Usuario usuario = usuarioBLL.LerPorID(saida.idUsuarioVendedor);
                if (usuario == null)
                {
                    erros.Add("usuario não encontrado no banco");
                }
            }
        }


    }
}
