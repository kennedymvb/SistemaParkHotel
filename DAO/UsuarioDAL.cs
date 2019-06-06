using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using Metadata;

namespace Metadata
{
    public class Usuario : IEntityCRUD<Usuario>
    {
        StringConexao stc = new StringConexao();
        Usuario usuario = new Usuario();



        public string Atualizar(Usuario item)
        {
            throw new NotImplementedException();
        }

        public string Excluir(Usuario item)
        {
            throw new NotImplementedException();
        }

        public string Inserir(Usuario item)
        {
            string stringConexao = stc.getStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO USUARIOS (ID, NOME, RG, CPF, ENDERECO, TELEFONE, EMAIL, SENHA) VALUES (@ID, @NOME, @RG, @CPF, @ENDERECO, @TELEFONE, @EMAIL, @SENHA)";
            command.Parameters.AddWithValue("@ID",  );
            command.Parameters.AddWithValue("@NOME", usuario.nome);
            command.Parameters.AddWithValue("@RG", cidade.Nome);
            command.Parameters.AddWithValue("@CPF", cidade.Estado.ID);
            command.Parameters.AddWithValue("@ENDERECO", cidade.Nome);
            command.Parameters.AddWithValue("@TELEFONE", cidade.Estado.ID);
            command.Parameters.AddWithValue("@EMAIL", cidade.Nome);
            command.Parameters.AddWithValue("@SENHAE", cidade.Estado.ID);
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
