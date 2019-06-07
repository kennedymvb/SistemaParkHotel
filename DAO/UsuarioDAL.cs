using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using Metadata;

namespace DAL
{
    public class UsuarioDAL : IEntityCRUD<Usuario>
    {
        StringConexao stc = new StringConexao();
        


        public string Atualizar(Usuario item)
        {
            throw new NotImplementedException();
        }

        public string Excluir(Usuario item)
        {
            throw new NotImplementedException();
        }

        public string Inserir(Usuario usuario)
        {
            string stringConexao = stc.getStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO USUARIOS (ID, NOME, RG, CPF, ENDERECO, TELEFONE, EMAIL, SENHA) VALUES (@ID, @NOME, @RG, @CPF, @ENDERECO, @TELEFONE, @EMAIL, @SENHA)";
            command.Parameters.AddWithValue("@ID", usuario.id );
            command.Parameters.AddWithValue("@NOME", usuario.nome);
            command.Parameters.AddWithValue("@RG", usuario.rg);
            command.Parameters.AddWithValue("@CPF", usuario.cpf);
            command.Parameters.AddWithValue("@ENDERECO", usuario.endereco);
            command.Parameters.AddWithValue("@TELEFONE", usuario.telefone);
            command.Parameters.AddWithValue("@EMAIL", usuario.email);
            command.Parameters.AddWithValue("@SENHA", usuario.senha);
            return "";
        }

        public Usuario LerPorID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> LerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
