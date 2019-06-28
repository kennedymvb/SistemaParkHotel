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
        public string tipo { get; set; }

        public Quarto(double ValorDiaria, int IDUsuario, string tipo)
        {
            this.valorDiaria = ValorDiaria;
            this.usuarioId = IDUsuario;
            this.tipo = tipo;
        }

        public Quarto()
        {
        }
    }
}
