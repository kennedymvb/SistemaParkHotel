using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metadata;
using DAL;

namespace BLL
{
    public class ReservaBLL
    {
        List<string> erros = new List<string>();

        ReservaDAL reservaDal = new ReservaDAL();

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





        public bool Validar(Reserva reserva)
        {
            if(reserva.id<1 || reserva.idCliente<1|| reserva.idQuarto<1|| reserva.idUsuario < 1)
            {
                erros.Add("os ids não podem ser menores que 1");
            }
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
    }
}
