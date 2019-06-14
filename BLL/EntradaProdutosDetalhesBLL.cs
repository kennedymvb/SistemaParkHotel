using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metadata;
using DAL;

namespace BLL
{
    public class EntradaProdutosDetalhesBLL
    {
        List<string> erros = new List<string>();

        EntradaProdutosDetalhesDAL entradaDal = new EntradaProdutosDetalhesDAL();

        public string inserir(EntradaProdutosDetalhes Entrada)
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

        public string atualizar(EntradaProdutosDetalhes Entrada)
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






        public bool Validar(EntradaProdutosDetalhes Entrada)
        {


            if (Entrada.valorUnitario < 0)
                erros.Add("o valor tem não pode ser negativo");

            if (Entrada.quantidade < 0)
            {
                erros.Add("a  quantidade não pode ser menor que 0");
            }


            if (erros.Count() > 0)
            {
                return false;
            }
            return true;


        }
    }
}
