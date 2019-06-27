using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Metadata;



namespace BLL
{
   public class CheckinBLL
   {
        List<string> erros = new List<string>();
        CheckinDAL checkinDAL = new CheckinDAL();

        public string inserir(Checkin checkin)
        {
            if (this.Validar(checkin))
            {
                return checkinDAL.Inserir(checkin);
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < erros.Count(); i++)
            {
                sb.Append(erros[i]);
            }
            return sb.ToString();
        }

        public Checkin LerPorID(int id)
        {
             return checkinDAL.LerPorID(id);
        }
        public List<Checkin> LerTodos()
        {
            return checkinDAL.LerTodos();
        }

        public bool Validar(Checkin checkin)
        {
            if (checkin.dataEntrada > checkin.dataPrevistaSaida)
            {
                return true;
            }
            return false;
        }

    }
}

