using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metadata;
using DAL;
using DAO.ReservaViewModel;

namespace BLL
{
    public class ReservaBLL
    {
        List<string> erros = new List<string>();

        ReservaDAL reservaDal = new ReservaDAL();
        QuartoDAL quartoDAL = new QuartoDAL();
        ClienteDAL clienteDAL = new ClienteDAL();
        UsuarioDAL usuarioDAL = new UsuarioDAL();
        public string inserir(Reserva reserva)
        {
            if (this.Validar(reserva))
            {
                return reservaDal.Inserir(reserva);
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < erros.Count(); i++)
            {
                sb.Append(erros[i]);
            }
            return sb.ToString();
        }

        public string Atualizar(Reserva reserva)
        {
            if (this.Validar(reserva))
            {
                return reservaDal.Atualizar(reserva);
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < erros.Count(); i++)
            {
                sb.Append(erros[i]);
            }
            return sb.ToString();
        }

        public Reserva LerPorID(int id)
        {
            return reservaDal.LerPorID(id);
        }

        public List<Reserva> LerTodos()
        {
            return reservaDal.LerTodos();
        }

        public bool Validar(Reserva reserva)
        {

            TratarDependencias(reserva);
            if (reserva.dataPrevisaoSaida < reserva.dataPrevisaoChegada)
            {
                erros.Add("datas inválidas");
            }

            if (erros.Count > 0)
            {
                return false;
            }
            return true;
        }


        private void TratarDependencias(Reserva reserva)
        {
            if (reserva.idQuarto < 0)
            {
                erros.Add("id do quarto deve ser informado");
            }
            else
            {
                Quarto quarto = quartoDAL.LerPorID(reserva.idQuarto);
                if (quarto == null)
                {
                    erros.Add("quarto não encontrado no banco");
                }
            }
            if (reserva.idCliente < 0)
            {
                erros.Add("id do produto deve ser informado");
            }
            else
            {
                Cliente cliente = clienteDAL.LerPorID(reserva.idCliente);
                if (cliente == null)
                {
                    erros.Add("cliente não encontrado no banco");
                }
            }
        }
        public List<ReservaViewModel> LerReservaViewModel()
        {
            return reservaDal.LerReservasViewModel();
        }
    }
}
