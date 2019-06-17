using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metadata;
using DAL;

namespace BLL
{
    public class CheckoutBLL
    {


        public CheckoutDAL checkoutDal = new CheckoutDAL();

        public CheckinDAL checkinDal = new CheckinDAL();

        public string Inserir(Checkout checkout)
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrWhiteSpace(checkout.valorTotal))
            {
                erros.Add("Valor deve ser informado.");
            }

            if (string.IsNullOrWhiteSpace(checkout.dataSaida))
            {
                erros.Add("data deve ser informada.");

            }

            if (checkout.dataSaida < checkin.dataEntrada)
            {
                erros.Add("Data de saída não pode ser antes da data de entrada.");


            }


            if (checkout.idCheckin < 1)
            {
                erros.Add("Checkin inválido.");
            }
         

            if (erros.Count != 0)
            {
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < erros.Count; i++)
                {
                    
                    builder.AppendLine(erros[i]);
                }
                return builder.ToString();
            }
            return checkoutDal.Inserir(checkout);
        }

    }






}

