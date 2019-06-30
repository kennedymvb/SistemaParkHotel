using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Cliente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string rg { get; set; }
        public string cpf { get; set; }
        public string telefone1 { get; set; }
        public string telefone2 { get; set; }
        public string email { get; set; }
        public int usuarioID { get; set; }

        public Cliente( string Nome, string RG, string CPF, string Tel1, string Tel2, string Email, int IDusuario)
        {
            this.nome = Nome;
            this.rg = RG;
            this.cpf = CPF;
            this.telefone1 = Tel1;
            this.telefone2 = Tel2;
            this.email = Email;
            this.usuarioID = IDusuario;
        }
        public Cliente()
        {

        }
      



    }
}
