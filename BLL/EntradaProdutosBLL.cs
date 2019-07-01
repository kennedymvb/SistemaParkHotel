using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Metadata;

namespace BLL
{
    public class EntradaProdutosBLL
    {
        List<string> erros = new List<string>();
        ProdutoDAL produtoDAL = new ProdutoDAL();
        SaidaProdutosDAL saidaDal = new SaidaProdutosDAL();
        ClienteDAL clienteDAL = new ClienteDAL();
        UsuarioDAL usuarioDAL = new UsuarioDAL();
        EntradaProdutosDAL entradaDal = new EntradaProdutosDAL();
        

        public int inserir(EntradaProdutos entrada)
        {
            if (this.Validar(entrada))
            {
                return entradaDal.Inserir(entrada);
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
        public List<EntradaProdutos> LerTodos()
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
                Usuario usuario = usuarioDAL.LerPorID(entrada.usuarioId);
                if (usuario == null)
                {
                    erros.Add("usuario não encontrado no banco");
                }
            }
        }
    }
}
