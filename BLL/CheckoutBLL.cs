using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metadata;
using DAL;
using BLL;

namespace BLL
{
    public class CheckoutBLL
    {
        Checkout checkout = new Checkout();
        CheckinDAL checkinDAL = new CheckinDAL();
        List<string> erros = new List<string>();

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

