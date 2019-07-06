using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metadata;
using DAL;
using System.Transactions;

namespace BLL
{
    public class CheckoutBLL
    {
        CheckoutDAL checkoutDal = new CheckoutDAL();
        List<string> erros = new List<string>();
        CheckinBLL checkinBLL = new CheckinBLL();
        QuartoBLL quartoBLL = new QuartoBLL();
        

        public void inserir(Checkout checkout)
        {
            if (this.Validar(checkout))
            {
                using (TransactionScope scope= new TransactionScope())
                {
                    checkoutDal.Inserir(checkout);
                    Checkin checkin = checkinBLL.LerPorID(checkout.idCheckin);
                    quartoBLL.Desocupar(checkin.quartoId);
                    checkin.PendenteCheckout = false;
                    scope.Complete();
                }
                
            }
            if (erros.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < erros.Count(); i++)
                {
                    sb.Append(erros[i]);
                }
                throw new Exception(sb.ToString());
            }
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
            TratarIntegridadeReferencial(checkout);
            if (checkout.dataSaida >= checkout.dataEntrada)
            {
                erros.Add("data saida não pode ser menor que a entrada");
                return true;
            }
            return false;
        }

        private void TratarIntegridadeReferencial(Checkout checkout)
        {
            if (checkout.idCheckin <= 0)
            {
                erros.Add("Checkin desse cliente não informado.");
            }
            else
            {
                Checkin checkin = checkinBLL.LerPorID(checkout.idCheckin);
                if (checkin == null)
                {
                    erros.Add("Checkin desse cliente não encontrado no banco.");
                }
            }
        }
    }
}

