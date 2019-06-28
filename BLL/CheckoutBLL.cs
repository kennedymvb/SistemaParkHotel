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
        CheckoutDAL checkoutDal = new CheckoutDAL();
        List<string> erros = new List<string>();

        public string inserir(Checkout checkout)
        {
            if (this.Validar(checkout))
            {
                return checkoutDal.Inserir(checkout);
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < erros.Count(); i++)
            {
                sb.Append(erros[i]);
            }
            return sb.ToString();
        }

        public Checkout LerPorID(int id)
        {
            return checkoutDal.LerPorID(id);
        }
        public List<Checkout> LerTodos()
        {
            return checkoutDal.LerTodos();
        }

        public bool Validar(Checkout checkout)
        {
            if (checkout.dataSaida >= checkout.dataEntrada)
            {
                erros.Add("data saida não pode ser menor que a entrada");
                return true;
            }
            return false;
        }
    }
}

