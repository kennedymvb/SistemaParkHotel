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

        

        CheckinDAL checkin = new CheckinDAL();


        public string Inserir(Checkin checkin)
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrWhiteSpace(checkin.dataEntrada))
            {
                erros.Add("data de entrada deve ser informada.");
            }

            if (string.IsNullOrWhiteSpace(checkin.dataPrevistaSaida))
            {
                erros.Add("data de previsão saida deve ser informada.");

            }

            if (checkin.dataPrevistaSaida < checkin.dataEntrada)
            {
                erros.Add("Data de saída não pode ser antes da data de entrada.");


            }


            if (checkin.quartoId < 1)
            {
                erros.Add("Numero de quarto inválido.");
            }

            if (checkin.clienteId < 1)
            {
                erros.Add("Numero de cliente inválido.");
            }

            if (checkin.idReserva < 1)
            {
                erros.Add("Numero de reserva inválido.");
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
            return checkinDal.Inserir(checkin);
        }

   }




}

