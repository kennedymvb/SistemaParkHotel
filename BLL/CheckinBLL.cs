using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using DAL;
using Metadata;



namespace BLL
{
    public class CheckinBLL
    {
        List<string> erros = new List<string>();
        CheckinDAL checkinDAL = new CheckinDAL();
        QuartoBLL quartoBll = new QuartoBLL();
        ClienteBLL clienteBll = new ClienteBLL();
        ReservaBLL reservaBll = new ReservaBLL();


        public string inserir(Checkin checkin)
        {
            Validar(checkin);
            if (erros.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < erros.Count(); i++)
                {
                    sb.Append(erros[i]);
                }
                return sb.ToString();
            }

            //Se chegou aqui, bora inserir o checkin e ocupar o quarto
            //TransactionScope Isolation Level (Serializable, COmmitedRead)
            using (TransactionScope scope = new TransactionScope())
            {
                checkinDAL.Inserir(checkin);
                quartoBll.Ocupar(checkin.quartoId);
                scope.Complete();
            }//scope.Dispose();
        }

        public Checkin LerPorID(int id)
        {
            return checkinDAL.LerPorID(id);
        }
        public List<Checkin> LerTodos()
        {
            return checkinDAL.LerTodos();
        }

        public void Validar(Checkin checkin)
        {
            if (checkin.dataEntrada > checkin.dataPrevistaSaida)
            {
                erros.Add("Data saída não pode ser menor que a data de entrada");
            }
            if (checkin.quartoId <= 0)
            {
                erros.Add("QUarto deve ser informado.");
            }
            else
            {
                Quarto quartoASerOcupado = quartoBll.LerPorID(checkin.quartoId);
                if (quartoASerOcupado == null)
                {
                    erros.Add("QUarto deve ser informado.");
                }
                else if (quartoASerOcupado.estaOcupado)
                {
                    erros.Add("O quarto já esta em uso.");
                }
            }
            if (checkin.clienteId<= 0)
            {
                erros.Add("Cliente deve ser informado.");
            }
            else
            {
                Cliente clienteAOcuparOQuarto = clienteBll.LerPorID(checkin.clienteId);
                if (clienteAOcuparOQuarto == null)
                {
                    erros.Add("Cliente deve ser informado.");
                }
            }
        }

    }
}

