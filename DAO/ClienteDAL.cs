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

        public string Atualizar(Cliente cliente)
        {
            string stringConexao = stc.getStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();

            command.Connection = connection;

            command.CommandText = "UPDATE CLIENTES SET NOME=@NOME, RG=@RG, CPF=@CPF, TELEFONE_1=@TELEFONE_1, TELEFONE_2=@TELEFONE_2, EMAIL=@EMAIL, USUARIO_ID=@USUARIO_ID)";
            command.Parameters.AddWithValue("@NOME", cliente.nome);
            command.Parameters.AddWithValue("@RG", cliente.rg);
            command.Parameters.AddWithValue("@CPF", cliente.cpf);
            command.Parameters.AddWithValue("@TELEFONE_1", cliente.telefone1);
            command.Parameters.AddWithValue("@TELEFONE_2", cliente.telefone2);
            command.Parameters.AddWithValue("@EMAIL", cliente.email);
            command.Parameters.AddWithValue("@USUARIO_ID", cliente.usuarioID);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                return "erro de conexão com o banco";
            }
            finally
            {
                connection.Close();
            }

            return "atualizado com sucesso";
        }

        public string Excluir(Cliente cliente)
        {
            string stringConexao = stc.getStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();

            command.CommandText = "delete from clientes WHERE ID= @ID ";
            command.Parameters.AddWithValue("@ID", cliente.id);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                return "erro de conexão com o banco";
            }
            finally
            {
                connection.Close();
            }
          

            return "cliente excluído";
        }

        public string Inserir(Cliente cliente)
        {

            string stringConexao = stc.getStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            command.CommandText = "INSERT INTO CLIENTES (NOME, RG, CPF, TELEFONE_1, TELEFONE_2, EMAIL, USUARIO_ID) VALUES (@NOME, @RG, @CPF, @TELEFONE_1, @TELEFONE_2, @EMAIL, @USUARIO_ID)";
            command.Parameters.AddWithValue("@NOME", cliente.nome);
            command.Parameters.AddWithValue("@RG", cliente.rg);
            command.Parameters.AddWithValue("@CPF", cliente.cpf);
            command.Parameters.AddWithValue("@TELEFONE_1", cliente.telefone1);
            command.Parameters.AddWithValue("@TELEFONE_2", cliente.telefone2);
            command.Parameters.AddWithValue("@EMAIL", cliente.email);
            command.Parameters.AddWithValue("@USUARIO_ID", cliente.usuarioID);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                return "erro de conexão com o banco";
            }

            return "cadastrado com sucesso";

        }

        public Cliente LerPorID(int id)
        {
            string stringConexao = stc.getStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                return "erro de conexão com o banco";
            }
            finally
            {
                connection.Close();
            }
        }

        public List<Cliente> LerTodos()
        {
            string stringConexao = stc.getStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;


            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                return "erro de conexão com o banco";
            }

        }
    }
}
