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

        EntradaProdutosDAL entradaDal = new EntradaProdutosDAL();
        

        public string inserir(EntradaProdutos entrada)
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
            return sb.ToString();
        }

        public string atualizar(EntradaProdutos entrada)
        {
            if (this.Validar(entrada))
            {
                return entradaDal.Atualizar(entrada);
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < erros.Count(); i++)
            {
                sb.Append(erros[i]);
            }
            return sb.ToString();
        }

        public bool Validar(EntradaProdutos entrada)
        {
            if ( entrada.valorTotal< 0)
            {
                erros.Add("o valor tem não pode ser negativo");

            }

            if (erros.Count() > 0)
            {
                return false;
            }
            return true;
        }
        public EntradaProdutos LerPorID(int id)
        {

            return entradaDal.LerTodos(id);

        }
        public List<EntradaProdutos> LerTodos()
        {
            return entradaDal.Inserir();
        }
    }
}
