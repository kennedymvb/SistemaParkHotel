using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Usuario
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string rg { get; set; }
        public string cpf { get; set; }
        public string endereco { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public bool isAdmin { get; set; }


        public Usuario(int ID, string Nome, string RG, string CPF, string Endereco, string Telefone, string Email, string Senha, bool IsAdmin)
        {

            this.id = ID;
            this.nome = Nome;
            this.rg = RG;
            this.cpf = CPF;
            this.endereco = Endereco;
            this.telefone = Telefone;
            this.email = Email;
            this.senha = Senha;
            this.isAdmin = IsAdmin;

        }

        public Usuario()
        {
        }
    }
}
