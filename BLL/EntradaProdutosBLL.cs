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
    public class EntradaProdutosBLL
    {
        List<string> erros = new List<string>();
        ProdutoBLL produtoBLL = new ProdutoBLL();
        ClienteBLL clienteBLL = new ClienteBLL();
        UsuarioBLL usuarioBLL = new UsuarioBLL();
        EntradaProdutosDAL entradaDal = new EntradaProdutosDAL();
        

        public int inserir(EntradaProdutos entrada)
        {
            if (this.Validar(entrada))
            {
                using(TransactionScope scope= new TransactionScope())
                {
                    try
                    {
                        entrada.id=entradaDal.Inserir(entrada);
                        entradaDal.InserirItens(entrada);
                        foreach (ItensEntrada item in entrada.itens)
                        {
                            Produto p = produtoBLL.LerPorID(item.idProduto);
                            int quantidadeAntiga = p.qtdEstoque;
                            double valorAntigo = p.preco;
                            p.qtdEstoque -= item.quantidade;
                            p.preco = (valorAntigo * quantidadeAntiga) + (item.quantidade * item.valorUnitario) / (quantidadeAntiga+item.quantidade);
                            produtoBLL.Atualizar(p);
                        }
                        scope.Complete();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Erro na transação: "+ex.Message);
                    }
                }

            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < erros.Count(); i++)
            {
                sb.Append(erros[i]);
            }
            throw new Exception(sb.ToString());
        }

        public bool Validar(EntradaProdutos entrada)
        {
            if ( entrada.valorTotal< 0)
            {
                erros.Add("o valor tem não pode ser negativo");
            }
            TratarDependencias(entrada);

            if (erros.Count() > 0)
            {
                return false;
            }
            return true;
        }
        public EntradaProdutos LerPorID(int id)
        {

            return entradaDal.LerPorID(id);

        }
        public List<EntradaProdutosViewModel> LerTodos()
        {
            return entradaDal.LerTodos();
        }

        private void TratarDependencias(EntradaProdutos entrada)
        {
            if (entrada.usuarioId < 0)
            {
                erros.Add("id do usuario deve ser informado");
            }
            else
            {
                Usuario usuario = usuarioBLL.LerPorID(entrada.usuarioId);
                if (usuario == null)
                {
                    erros.Add("usuario não encontrado no banco");
                }
            }
        }
    }
}
