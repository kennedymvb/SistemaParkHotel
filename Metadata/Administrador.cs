using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Administrador:Usuario
    {
        public Administrador(string cpf, string email, bool isAdmin, string senha, string telefone, string rg)
        {
            this.cpf = cpf;
            this.email = email;
            this.endereco = endereco;
            this.isAdmin = isAdmin;
            this.senha = senha;
            this.telefone = telefone;
            this.rg = rg;
        }
        public Administrador()
        {
                
        }

    }
}
