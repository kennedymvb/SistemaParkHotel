using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using DAL;
using Metadata;
namespace BLL
{
    public class SaidaProdutosBLL
    {
        List<string> erros = new List<string>();
        ProdutoDAL produtoDAL = new ProdutoDAL();
        SaidaProdutosDAL saidaDal = new SaidaProdutosDAL();
        ClienteDAL clienteDAL = new ClienteDAL();
        UsuarioDAL usuarioDAL = new UsuarioDAL();

        public void inserir(SaidaProdutos saida)
        {
            if (this.Validar(saida))
            {
                using (TransactionScope scope= new TransactionScope())
                {

                    saida.id = saidaDal.Inserir(saida);
                    saidaDal.InserirItens(saida);
                    scope.Complete();
                    
                }
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < erros.Count(); i++)
            {
                sb.Append(erros[i]);
            }
            throw new Exception(sb.ToString());
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
        public List<SaidaProdutos> LerTodos()
        {
            return saidaDal.LerTodos();
        }

        private void TratarDependencias(SaidaProdutos saida)
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
            if (saida.idUsuarioVendedor < 0)
            {
                erros.Add("id do vendedor deve ser informado");
            }
            else
            {
                Usuario usuario = usuarioDAL.LerPorID(saida.idUsuarioVendedor);
                if (usuario == null)
                {
                    erros.Add("usuario não encontrado no banco");
                }
            }
        }


    }
}
