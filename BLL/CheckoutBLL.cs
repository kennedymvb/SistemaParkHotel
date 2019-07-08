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
        SaidaProdutosBLL saidaProdutosBLL = new SaidaProdutosBLL();

        public void inserir(Checkout checkout)
        {
            if (this.Validar(checkout))
            {
                try
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        checkoutDal.Inserir(checkout);
                        Checkin checkin = checkinBLL.LerPorID(checkout.idCheckin);
                        checkinBLL.AtualizarPendenciaCheckout(checkin.id);
                        quartoBLL.Desocupar(checkin.quartoId);
                        scope.Complete();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
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
            try
            {
                return checkoutDal.LerPorID(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public double calcularValorTotal(Checkin checkinCorrespondente, Checkout checkout)
        {
            return getValorDiarias(checkinCorrespondente, checkout) + getValorCompras(checkinCorrespondente);
        }

        private double getValorDiarias(Checkin checkin, Checkout checkout)
        {
            return getTotalDias(checkout) * getvalorDiario(checkin);
        }

        private double getvalorDiario(Checkin checkin)
        {
            return quartoBLL.LerPorID(checkin.quartoId).valorDiaria;
        }

        private double getTotalDias(Checkout checkout)
        {
            DateTime dataEntrada = checkout.dataEntrada;
            DateTime dataSaida = checkout.dataSaida;
            TimeSpan diferenca = dataSaida.Subtract(dataEntrada);
            double totalDias = Math.Ceiling(diferenca.TotalDays);
            if (totalDias == 0)
            {
                totalDias = 1;
            }
            return totalDias;//se fez checkin, já tem que pagar a diária
        }

        private double getValorCompras(Checkin checkin)
        {
            double somaTotal = 0;
            List<double> ListaTotalCompras = saidaProdutosBLL.LerPorCheckinId(checkin.id);
            foreach (double item in ListaTotalCompras)
            {
                somaTotal += item;
            }
            return somaTotal;
        }

        public List<Checkout> LerTodos()
        {
            try
            {
                return checkoutDal.LerTodos();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void atualizarValorTotal(Checkout checkout)
        {
            checkoutDal.AtualizarValorTotal(checkout);
        }

        public bool Validar(Checkout checkout)
        {
            TratarIntegridadeReferencial(checkout);
            TimeSpan diferenca = checkout.dataSaida.Subtract(checkout.dataEntrada);
            
            if (diferenca.TotalMinutes<=0)
            {
                erros.Add("data saida tem que ser maior que a data de entrada");
                return false;
            }
            return true;
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

