using BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class ClientesDAL : IEntityCRUD<Cliente>

    {

        StringConexao stc = new StringConexao();

        public string Atualizar(Cliente item)
        {
            string stringConexao = stc.getStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
        }

        public string Excluir(Cliente item)
        {
            string stringConexao = stc.getStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
        }

        public string Inserir(Cliente cliente)
        {

            string stringConexao = stc.getStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();

            command.CommandText = "INSERT INTO USUARIOS (NOME, RG, CPF, TELEFONE_1, TELEFONE_2, EMAIL, USUARIO_ID) VALUES (@NOME, @RG, @CPF, @TELEFONE_1, @TELEFONE_2, @EMAIL, @USUARIO_ID)";
            command.Parameters.AddWithValue("@NOME", cliente.nome);
            command.Parameters.AddWithValue("@RG", cliente.rg);
            command.Parameters.AddWithValue("@CPF", cliente.cpf);
            command.Parameters.AddWithValue("@TELEFONE_1", cliente.telefone1);
            command.Parameters.AddWithValue("@TELEFONE_2", cliente.telefone2);
            command.Parameters.AddWithValue("@EMAIL", cliente.email);
            command.Parameters.AddWithValue("@USUARIO_ID", cliente.usuarioID);

            return "";

        }

        public Cliente LerPorID(int id)
        {
            string stringConexao = stc.getStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
        }

        public List<Cliente> LerTodos()
        {
            string stringConexao = stc.getStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
        }
    }
}
