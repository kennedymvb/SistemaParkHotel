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
            if (this.Validar(saidaProdutosDetalhes))
            {
                return saidaDal.LerPorID(saidaProdutosDetalhes.id);
            }

            return null;
        }
        public List<SaidaProdutosDetalhes> LerTodos()
        {
            return saidaDal.LerTodos();
        }
    }
}
