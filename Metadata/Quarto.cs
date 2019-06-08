using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Quarto
    {
        public int id { get; set; }
        public double valorDiaria {get; set;}
        public int usuarioId { get; set; }
        public bool estaOcupado { get; set; }

        public Quarto(int ID, double ValorDiaria, int IDUsuario, bool EstaOcupado)
        {
            this.id = ID;
            this.valorDiaria = ValorDiaria;
            this.usuarioId = IDUsuario;
            this.estaOcupado = EstaOcupado;
        }



    }
}
