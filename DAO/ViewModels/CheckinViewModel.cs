using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.ViewModels
{
    public class CheckinViewModel
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public int quarto { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataPrevistaSaida { get; set; }
        public bool CheckoutPendente { get; set; }
        public int idReserva { get; set; }

        public CheckinViewModel(int id, string cliente, int quarto, DateTime dataEntrada, DateTime dataPrevista, bool checkoutPendente)
        {
            this.CheckoutPendente = checkoutPendente;
            this.Cliente = cliente;
            this.DataEntrada = dataEntrada;
            this.DataPrevistaSaida = dataPrevista;
            this.Id=id;
            this.quarto = quarto;
        }
        public CheckinViewModel()
        {

        }


    }
}
