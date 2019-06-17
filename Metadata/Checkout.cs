using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Checkout
    {
        public int id { get; set; }
        public int idCheckin { get; set; }
        public double valorTotal { get; set; }
        public DateTime dataSaida { get; set; }

        public Checkout(int id, int idcheckin, double valortotal, DateTime datasaida)
        {
            this.id = id;
            this.idCheckin = idcheckin;
            this.valorTotal = valortotal;
            this.dataSaida = datasaida;
        }
        public Checkout()
        {

        }



    }
}
