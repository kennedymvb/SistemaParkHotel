using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Fornecedor
    {
        public int id { get; set; }
        public string razaoSocial { get; set; }
        public string rg { get; set; }
        public string cnpj { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public int usuarioID { get; set; }
        public string nomeContato { get; set; }

        public Fornecedor(int ID, string RazaoSocial, string RG, string CNPJ, string Telefone, string Email, int IDusuario, string Nomecontato)
        {

            this.id = ID;
            this.razaoSocial = RazaoSocial;
            this.rg = RG;
            this.cnpj = CNPJ;
            this.telefone = Telefone;
            this.email = Email;
            this.usuarioID = IDusuario;
            this.nomeContato = Nomecontato;

        }




    }
}
