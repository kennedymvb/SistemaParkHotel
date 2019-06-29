using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Metadata;

namespace BLL
{
    public class QuartoBLL
    {
        List<string> erros = new List<string>();

         QuartoDAL quartoDal = new QuartoDAL();

        public string inserir(Quarto quarto)
        {
            if (this.Validar(quarto))
            {
                return quartoDal.Inserir(quarto);
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < erros.Count(); i++)
            {
                sb.Append(erros[i]);
            }
            return sb.ToString();
        }

        public string Atualizar(Quarto quarto)
        {
            if (this.Validar(quarto))
            {
                return quartoDal.Atualizar(quarto);
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < erros.Count(); i++)
            {
                sb.Append(erros[i]);
            }
            return sb.ToString();
        }

        public bool Validar(Quarto quarto)
        {
            if (quarto.valorDiaria<0)
            {
                erros.Add("valor inválido");
            }

            if (erros.Count > 0)
            {
                return false;
            }
            return true;
        }

        public Quarto LerPorID(int id)
        {
            return quartoDal.LerPorID(id);
        }
        public List<Quarto> LerTodos()
        {
            return quartoDal.LerTodos();
        }
        public void Ocupar(int idQuarto)
        {
            Quarto quarto = new Quarto();
            quarto = LerPorID(idQuarto);
            quarto.estaOcupado = true;
            Atualizar(quarto);
        }
        public void Desocupar(int idQuarto)
        {
            Quarto quarto = new Quarto();
            quarto = LerPorID(idQuarto);
            quarto.estaOcupado = false;
            Atualizar(quarto);
        }
    }
}
