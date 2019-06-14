using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Metadata;

namespace BLL
{
    public class EntradaProdutos
    {
        List<string> erros = new List<string>();

        EntradaProdutosDAL entradaDal = new EntradaProdutosDAL();

        public string inserir(EntradaProdutos Entrada)
        {
            if (this.Validar(Entrada))
            {
                return entradaDal.Inserir(Entrada);
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < erros.Count(); i++)
            {
                sb.Append(erros[i]);
            }
            return sb.ToString();
        }

        public string atualizar(EntradaProdutos Entrada)
        {
            if (this.Validar(Entrada))
            {
                return entradaDal.Atualizar(Entrada);
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < erros.Count(); i++)
            {
                sb.Append(erros[i]);
            }
            return sb.ToString();
        }






        public bool Validar(EntradaProdutos Entrada)
        {


            if (Entrada. < 0)
                erros.Add("o valor tem não pode ser negativo");

           


            if (erros.Count() > 0)
            {
                return false;
            }
            return true;


        }
    }
}
